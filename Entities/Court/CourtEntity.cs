namespace PLDS_Data.Entities.Court
{
    public class CourtEntity
    {
        public int CourtId { get; set; }

        public string CourtName { get; set; }

        public int CourtTypeId { get; set; }

        public string CourtTypeDescription { get; set; }

    }

    public struct CourtTypeEntity
    {
        public int CourtTypeId { get; set; }

        public string CourtTypeDescription { get; set; }

    }

}
