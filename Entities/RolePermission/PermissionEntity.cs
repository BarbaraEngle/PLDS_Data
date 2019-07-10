using System.ComponentModel.DataAnnotations;

namespace PLDS_Data.Entities.RolePermission
{
    public class PermissionEntity
    {
        [Display(Name = "Permission Id")]
        public int PermissionId { get; set; }

        [Display(Name = "Permission")]
        public string PermissionName { get; set; }

        public bool IsActive { get; set; }

    }
}
