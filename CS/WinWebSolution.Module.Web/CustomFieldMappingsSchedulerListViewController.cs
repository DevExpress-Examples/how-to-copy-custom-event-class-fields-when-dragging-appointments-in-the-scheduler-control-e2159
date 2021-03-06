using System;
using DevExpress.XtraScheduler;
using System.Collections.Generic;
using DevExpress.Web.ASPxScheduler;
using DevExpress.ExpressApp.Scheduler.Web;

namespace WinWebSolution.Module.Web {
    public class CustomFieldMappingsSchedulerListViewController : CustomFieldMappingsSchedulerListViewControllerBase {
        protected override void AddCustomFieldMappings(List<MappingBase> mappings) {
            ASPxScheduler scheduler = ((ASPxSchedulerListEditor)this.SchedulerListEditor).SchedulerControl;
            scheduler.Storage.Appointments.CustomFieldMappings.AddRange(mappings);
        }
    }
}
