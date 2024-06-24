using ERPCivil.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPCivil.BusinessServices.Interface
{
public interface IUserService
	{

		bool AddEditUser (UserViewModel userViewModel);

		public List<UserViewModel> GetUser();


	}
}
