﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disco.Models.UI.Config.DeviceProfile
{
    public interface ConfigDeviceProfileShowModel : BaseUIModel
    {
        Disco.Models.Repository.DeviceProfile DeviceProfile { get; set; }
        List<Disco.Models.BI.Config.OrganisationAddress> OrganisationAddresses { get; set; }

        bool CanDelete { get; set; }
    }
}