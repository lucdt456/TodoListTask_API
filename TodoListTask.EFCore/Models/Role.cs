using System.ComponentModel.DataAnnotations;

namespace TodoListTask.EFCore.Models
{
	public class Role
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(100)]
		public string RoleName { get; set; }

		[StringLength(255)]
		public string Description { get; set; }
		public DateTime CreateAt { get; set; }

		public ICollection<UserRole> UserRoles { get; set; }
		public ICollection<RolePermission> RolePermissions { get; set; }
	}
}
