using System;

namespace PLDS_Data.Entities.Document
{ 
    public class DocumentEntity
    {
        public int DocumentId { get; set; }

        public int DocHeaderId { get; set; }

        public string DocumentReferenceNo { get; set; }

        public int DefendantSheriffId { get; set; }
    }

    public class DocHeaderEntity
    {
        public int DocHeaderId { get; set; }
        public int ServiceId { get; set; }
        public string MatterNo { get; set; }
        public DateTime? LodgementDate { get; set; }
        public string CaseNo { get; set; }
        public DateTime? IssueDate { get; set; }
        public string Plaintiff { get; set; }
        public int DocumentCount { get; set; }
    }
}
