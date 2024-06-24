using ERPCivil.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPCivil.Repository.Interface
{
	public interface IAdminRepository
	{
		bool AddEditAdmin(Admin admin);

		bool DeleteAdmin(int id);

		List<Admin> GetAllAdmins();

		Admin GetAdmin(int id);

		Admin LoginCheck(string  username, string password,out bool IsSuccess);
	}
}
