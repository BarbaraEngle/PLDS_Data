namespace PLDS_Data.Entities.DocumentStatus
{
    public class DocumentStatusEntity
    {
        public int DocumentStatusId { get; set; }

        public int DocumentId { get; set; }

        public int StatusId { get; set; }

        public bool IsActive { get; set; }

    }

    public class ResponseEntity
    {
        public int ResponseId { get; set; }

        public int DocumentStatusId { get; set; }

        public string ResponseContent { get; set; }
    }
}
