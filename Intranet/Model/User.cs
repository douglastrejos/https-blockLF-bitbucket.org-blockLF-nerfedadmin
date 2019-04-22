using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Intranet.Model
{
    public class User
    {
        public User()
        {
            
        }
        public int UserId { get; set; }

        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }

        [MaxLength(256)]
        public string UserName { get; set; }      
        

        [Required]
        [MaxLength(256)]
        public string EmailAddress { get; set; }

        [MaxLength(100)]
        public string Phone { get; set; }

        [MaxLength(100)]
        public string WhatsApp { get; set; }

        [MaxLength(100)]
        public string Telegram { get; set; }

        [MaxLength(100)]
        public string Discord { get; set; }

        [MaxLength(100)]
        public string Skype { get; set; }

        [MaxLength(500)]
        public string Skills { get; set; }

        public int IdRolPosition { get; set; }

        public DateTime AdmissionDate { get; set; }

        [MaxLength(100)]
        public string Hash { get; set; }

        [MaxLength(100)]
        public string Salt { get; set; }

        public DateTime CreatedAt { get; set; }

        [MaxLength(500)]
        public string Token { get; set; }

        public string Avatar { get; set; }   
        
        public virtual SecurityRol SecurityRol { get; set; }
    }
}
