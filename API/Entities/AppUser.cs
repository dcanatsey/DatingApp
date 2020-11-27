using System;
using System.Collections.Generic;
using API.Extensions;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String KnownAs { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;
        public String Gender { get; set; }
        public String Introducion { get; set; }
        public String LookingFor { get; set; }
        public String Interests { get; set; }
        public String City { get; set; }
        public String Country { get; set; }
        public ICollection<Photo> Photos { get; set; }

      /*   public int GetAge()
        {
            return DateOfBirth.CalculateAge();
            
        }
 */
    }
}