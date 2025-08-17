using Microsoft.EntityFrameworkCore;
using TodoListTask.EFCore.Models;

namespace TodoListTask.EFCore.EntityFrameworkCore
{
	public class TodoListDbContext : DbContext
	{
		public TodoListDbContext(DbContextOptions<TodoListDbContext> options) : base(options)
		{

		}
		public DbSet<User> Users { get; set; }
		public DbSet<Permission> Permissions { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<UserRole> UserRoles { get; set; }
		public DbSet<RolePermission> RolePermissions { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<RolePermission>()
					.HasKey(r => new { r.RoleId, r.PermissionId });
			modelBuilder.Entity<UserRole>()
					.HasKey(ur => new { ur.UserId, ur.RoleId });
		}
	}
}
