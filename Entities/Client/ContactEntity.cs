namespace PLDS_Data.Entities.Client
{
    public class ClientContactEntity
    {
        public int ClientContactId { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string FullName { get; set; }

        public string KnownAs { get; set; }

        public string Tel1 { get; set; }

        public string Tel2 { get; set; }

        public string ContactEmail { get; set; }

        public string Designation { get; set; }

        public string Department { get; set; }

        public int ClientId { get; set; }
        public ClientEntity Client { get; set; }

    }
}
