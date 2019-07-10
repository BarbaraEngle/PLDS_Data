namespace PLDS_Data.Entities.Defendant
{
    public class DefendantEntity
    {
        public int DefendantId { get; set; }
        public int DocumentId { get; set; }
        public string FirstNames { get; set; }
        public string Surname { get; set; }
        public string DefendantIdNo { get; set; }
        public int AddressId { get; set; }
    }
}
