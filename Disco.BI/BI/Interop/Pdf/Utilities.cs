using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.IO;

namespace Disco.BI.Interop.Pdf
{
    public static class Utilities
    {
        public static Stream JoinPdfs(bool InsertBlankPages, List<Stream> Pdfs)
        {
            if (Pdfs.Count == 0)
                throw new System.ArgumentNullException(nameof(Pdfs));

            // Only One PDF - Possible Reference Bug v's Memory/Speed (Returning Param Memory Stream)
            if (Pdfs.Count == 1)
                return Pdfs[0];

            // Join Pdfs
            var msBuilder = new MemoryStream();

            var pdfLastPageSize = PageSize.A4;
            var pdfDoc = new Document();
            var pdfCopy = new PdfSmartCopy(pdfDoc, msBuilder);
            pdfDoc.Open();
            pdfCopy.CloseStream = false;

            for (int i = 0; i < Pdfs.Count; i++)
            {
                var pdf = Pdfs[i];
                var pdfReader = new PdfReader(pdf);

                for (int indexPage = 1; indexPage <= pdfReader.NumberOfPages; indexPage++)
                {
                    pdfLastPageSize = pdfReader.GetPageSizeWithRotation(indexPage);
                    var page = pdfCopy.GetImportedPage(pdfReader, indexPage);
                    pdfDoc.SetPageSize(pdfLastPageSize);
                    pdfDoc.NewPage();
                    pdfCopy.AddPage(page);
                }

                if (InsertBlankPages && (pdfCopy.PageNumber % 2) != 0)
                {
                    pdfDoc.NewPage();
                    pdfCopy.AddPage(pdfLastPageSize, 0);
                }

                pdfReader.Close();
            }

            pdfDoc.Close();
            pdfCopy.Close();
            msBuilder.Position = 0;

            return msBuilder;
        }
    }
}
