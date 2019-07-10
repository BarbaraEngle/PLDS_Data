using System.ComponentModel.DataAnnotations;

namespace PLDS_Data.Entities.Transfer
{
    public class JobTransferEntity
    {
        public int JobTransferId { get; set; }

        public int JobId { get; set; }

        public int ProcessId { get; set; }

        public int ServiceProviderId { get; set; }
    }

    public class JobTransferDisplayItem
    {
        public int JobTransferId { get; set; }

        [Display(Name = "Client")]
        public string ClientName { get; set; }

        [Display(Name = "Job Reference No")]
        public string JobReferenceNo { get; set; }

        [Display(Name = "Process")]
        public string ProcessDescription { get; set; }

        [Display(Name = "Service Provider")]
        public string ServiceProvider { get; set; }

        [Display(Name = "Job Transfer Status")]
        public string JobTransferStatus { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }
        public string ButtonDescription { get; set; }
        public string BtnDisabled { get; set; }

    }

}
