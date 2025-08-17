using Microsoft.Extensions.DependencyInjection;
using TodoListTask.Service.Services.Authenticate;

namespace TodoListTask.Service.DependencyInjection
{
	public static class AddServicesExtention
	{
		public static IServiceCollection AddServices(this IServiceCollection services)
		{
			// Register services here
			services.AddScoped<ILoginService, LoginService>();
			return services;
		}
	}
}
