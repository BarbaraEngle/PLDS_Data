using System.ComponentModel.DataAnnotations;

namespace PLDS_Data.Entities
{
    public class CorrespondentEntity
    {
        public int CorrespondentId { get; set; }

        [Display(Name = "Correspondent")]
        public string Correspondent { get; set; }

        [Display(Name = "Correspondent Branch")]
        public string CorrespondentBranch { get; set; }
    }
}
