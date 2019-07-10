using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PLDS_Data.Entities.RolePermission
{
    public class RoleEntity
    {
        [Display(Name = "Role Id")]
        public int RoleId { get; set; }

        [Display(Name = "Role")]
        public string RoleName { get; set; }

        [Display(Name = "Is Sys Admin")]
        public bool IsSysAdmin { get; set; }

        public bool IsActive { get; set; }

        public List<PermissionsForRole> Permissions { get; set; }

    }

    public class PermissionsForRole
    {
        [Display(Name = "Permission Id")]

        public int PermissionId { get; set; }

        [Display(Name = "Permission")]

        public string PermissionName { get; set; }

        public bool IsAssigned { get; set; }

    }
}
