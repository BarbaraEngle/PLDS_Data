using PLDS_Data.Entities.Generic;
using System.ComponentModel.DataAnnotations;

namespace PLDS_Data.Entities.ServicePack
{
    public class ServicePackEntity
    {
        public int ServicePackId { get; set; }

        public string ServicePackReferenceNo { get; set; }

        public int JobId { get; set; }

        public int? CourtId { get; set; }

        public int? SheriffId { get; set; }

        public int ServiceProviderId { get; set; }
    }

    public class ServicePackDisplayItem
    {
        public int JobId { get; set; }

        [Display(Name = "Job Reference No")]
        public string JobReferenceNo { get; set; }

        [Display(Name = "Client")]
        public string ClientName { get; set; }

        [Display(Name = "Service Pack Reference No")]
        public string ServicePackReferenceNo { get; set; }
        public int ServicePackId { get; set; }

        [Display(Name = "Court")]
        public string CourtName { get; set; }

        [Display(Name = "Sheriff")]
        public string SheriffName { get; set; }

        [Display(Name = "Service Provider")]
        public string ServiceProviderName { get; set; }

        public ButtonDefinition ActionButton { get; set; }

        public ButtonDefinition CancelButton { get; set; }

    }

}
