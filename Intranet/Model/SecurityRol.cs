using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Intranet.Model
{
    public class SecurityRol
    {
        public SecurityRol()
        {
            Users = new HashSet<User>();
        }

        public int SecurityRolId { get; set; }

        [MaxLength(100)]
        public string RolName { get; set; }

        public DateTime DateRegistered { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
