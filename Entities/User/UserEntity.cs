using PLDS_Data.Entities.RolePermission;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PLDS_Data.Entities
{
    public class UserEntity
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string UserPassword { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }

        public IEnumerable<RoleEntity> UserRoles { get; set; }
    }

    public class UserDisplayItem
    {

        public int UserId { get; set; }

        [Display(Name = "Username")]
        [Required, MaxLength(100)]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Surname")]
        public string Surname { get; set; }

        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        private string _fullName;

        [Display(Name = "Full Name")]
        public string FullName { get => _fullName = FirstName + ' ' + Surname; set => _fullName = FirstName + ' ' + Surname; }

    }

}
