using ERPCivil.Repository.Concrete;
using ERPCivil.Repository.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPCivil.Repository
{
public class RepositoryDependencyContainer
	{
		public static void Register (IServiceCollection servicecollection)
		{
			servicecollection.AddScoped<IAdminRepository,AdminRepository>();
			servicecollection.AddScoped<IUserRepository,UserRepository>();
		}



	}
}
