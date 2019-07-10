using System.ComponentModel.DataAnnotations;

namespace PLDS_Data.Entities.Client
{
    public class CRMClientEntity
    {
        [Display(Name = "CRM Client Id")]
        public int CRMId { get; set; }

        [Display(Name = "Client Name")]
        public string CRMName { get; set; }

        [Display(Name = "Trading As")]

        public string TradingAs { get; set; }

        [Display(Name = "Pastel Account No.")]
        public string PastelAccountNo { get; set; }

        [Display(Name = "Address Line 1")]
        public string PhysicalAdd1 { get; set; }

        [Display(Name = "Address Line 2")]
        public string PhysicalAdd2 { get; set; }

        [Display(Name = "Address Line 3")]

        public string PhysicalAdd3 { get; set; }
        [Display(Name = "Address Line 4")]

        public string PhysicalAdd4 { get; set; }
        [Display(Name = "Postal code")]

        public string PhysicalPCode { get; set; }

        [Display(Name = "City")]

        public string PhysicalCity { get; set; }

        [Display(Name = "Province")]

        public string PhysicalProvince { get; set; }

        [Display(Name = "Country")]

        public string PhysicalCountry { get; set; }
        public float PhysicalX { get; set; }
        public float PhysicalY { get; set; }
    }
}
