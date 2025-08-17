using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoListTask.EFCore.Models
{
	[Table("RolePermissions")]
	public class RolePermission
	{
		[Required]
		[ForeignKey("Role")]
		public int RoleId { get; set; }

		public Role Role { get; set; }

		[Required]
		[ForeignKey("Permission")]
		public int PermissionId { get; set; }

		public Permission Permission { get; set; }
	}
}

