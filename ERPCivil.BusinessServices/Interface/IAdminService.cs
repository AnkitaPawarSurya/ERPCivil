using ERPCivil.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPCivil.BusinessServices.Interface
{
public interface IAdminService
	{
		bool AddEditAdmin(AdminViewModel admin );

		bool DeleteAdmin(int id);

		List<AdminViewModel> GetAllAdmins();

		AdminViewModel GetAdmin(int id);

		bool AdminRegisteration(AdminViewModel adminviewmodel);

		AdminViewModel LoginCheck(string username,string password,out bool IsSuccess);

	}
}
