namespace PLDS_Data.Entities.Document
{
    public class DocumentLabelEntity
    {
        public int JobId { get; set; }
        public int ServicePackId { get; set; }
        public int DocumentId { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string JobRefNo { get; set; }
        public int CourtId { get; set; }
        public string CourtType { get; set; }
        public string CourtName { get; set; }
        public int SheriffId { get; set; }
        public string SheriffName { get; set; }
        public int ProcessId { get; set; }
        public string ProcessName { get; set; }
        public string MatterNo { get; set; }
        public string DocRefNo { get; set; }
        public string DocumentLabel { get; set; }
    }

}
