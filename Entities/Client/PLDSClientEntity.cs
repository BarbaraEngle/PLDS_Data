using System.ComponentModel.DataAnnotations;

namespace PLDS_Data.Entities
{
    public class PLDSClientEntity
    {
        [Display(Name = "PLDS Client Id")]
        public int PLDSClientId { get; set; }

        public int CRMClientId { get; set; }

        [Display(Name = "Client Name")]
        public string ClientName { get; set; }

        [Display(Name = "Client Email")]
        [DataType(DataType.EmailAddress)]
        public string ClientEmail { get; set; }

        [Display(Name = "PLDS Enabled")]
        public bool PLDSEnabled { get; set; }

    }
}
