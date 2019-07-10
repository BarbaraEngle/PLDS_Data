using PLDS_Data.Entities.Process;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PLDS_Data.Entities.Service
{
    public class ServiceEntity
    {
        public int ServicePackId { get; set; }
        public int ServiceId { get; set; }
        public int DocumentQty { get; set; }
        public int ProcessId { get; set; }

        public List<int> ServiceStepIds { get; set; }
    }

    public class ServiceStepEntity
    {
        public int ServiceStepId { get; set; }
        public int ServiceId { get; set; }
        public int ProcessStepId { get; set; }
    }

    public class ServiceDisplayItem
    {
        public int JobId { get; set; }

        [Display(Name = "Job Reference No")]
        public string JobReferenceNo { get; set; }

        [Display(Name = "Client")]
        public string ClientName { get; set; }

        [Display(Name = "Court")]
        public string CourtName { get; set; }

        [Display(Name = "Sheriff")]
        public string SheriffName { get; set; }

        public int ServicePackId { get; set; }

        [Display(Name = "Service Provider")]
        public string ServiceProviderName { get; set; }

        public int ServiceId { get; set; }

        public int ProcessId { get; set; }

        public List<int> ProcessStepIds { get; set; } = new List<int>();

        public IEnumerable<ProcessStepEntity> ProcessSteps = new List<ProcessStepEntity>();

        [Display(Name = "Process Type")]
        public string ProcessTypeDescription { get; set; }

        [Display(Name = "Process")]
        public string ProcessDescription { get; set; }

        [Display(Name = "Quantity")]
        public int DocumentQty { get; set; }
    }
}
