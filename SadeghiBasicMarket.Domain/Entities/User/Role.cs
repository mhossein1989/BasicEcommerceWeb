using System.Collections.Generic;

namespace SadeghiBasicMarket.Domain.Entities
{
    public class Role
    {
        public long Id { get; set; }
        public string  Name { get; set; }
        public ICollection<UserInRole > UserInRoles { get; set; }
    }
}
