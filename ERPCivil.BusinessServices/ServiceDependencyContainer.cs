using ERPCivil.BusinessServices.Concrete;
using ERPCivil.BusinessServices.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPCivil.BusinessServices
{
public static class ServiceDependencyContainer
	{ 
		public static void Register(IServiceCollection services)
		{
			services.AddScoped<IAdminService,AdminService>();
			services.AddScoped<IUserService,UserService>();
		}

	}
}
