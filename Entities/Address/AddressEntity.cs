namespace PLDS_Data.Entities.Address
{
    public class AddressEntity
    {
        public int AddressId { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string Line4 { get; set; }
        public string PostalCode { get; set; }
        public string Town { get; set; }
        public int ProvinceId { get; set; }
        public int CountryId { get; set; }
    }
    public class ProvinceEntity
    {
        public int ProvinceId { get; set; }
        public string ProvinceName { get; set; }
    }

    public class CountryEntity
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
    }

}
