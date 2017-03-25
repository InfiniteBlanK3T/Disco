﻿using Disco.Data.Repository;
using Disco.Models.Services.Devices.Importing;
using Disco.Services.Tasks;
using Quartz;
using System;

namespace Disco.Services.Devices.Importing
{
    public class DeviceImportApplyTask : ScheduledTask
    {
        private const string JobDataMapContext = "Context";

        public override string TaskName { get { return "Import Devices - Applying Changes"; } }
        public override bool SingleInstanceTask { get { return false; } }
        public override bool CancelInitiallySupported { get { return false; } }

        public static ScheduledTaskStatus ScheduleNow(IDeviceImportContext Context)
        {
            if (Context == null)
                throw new ArgumentNullException(nameof(Context));

            // Build Data Map
            var task = new DeviceImportApplyTask();
            JobDataMap taskData = new JobDataMap() { { JobDataMapContext, Context } };

            // Schedule Task
            return task.ScheduleTask(taskData);
        }

        protected override void ExecuteTask()
        {
            var context = (IDeviceImportContext)ExecutionContext.JobDetail.JobDataMap[JobDataMapContext];

            using (DiscoDataContext Database = new DiscoDataContext())
            {
                context.AffectedRecords = context.ApplyRecords(Database, Status);
            }

            Status.SetFinishedMessage($"Successfully imported/updated {context.AffectedRecords} device{(context.AffectedRecords == 1 ? null : "s")}");
        }
    }
}
