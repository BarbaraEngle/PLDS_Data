using System.Collections.Generic;

namespace PLDS_Data.Entities.Client
{
    public class ClientEntity
    {
        public int ClientId { get; set; }

        public string CompanyName { get; set; }

        public ICollection<ClientContactEntity> Contacts { get; set; } = new List<ClientContactEntity>();

    }
}
