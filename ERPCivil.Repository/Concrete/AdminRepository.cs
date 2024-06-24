using ERPCivil.Common;
using ERPCivil.DataEntity;
using ERPCivil.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPCivil.Repository.Concrete
{
	public class AdminRepository : IAdminRepository
	{
		private ErpcivilContext _erpcivilContext;

			public AdminRepository(ErpcivilContext erpcivilContext)
			{
			      _erpcivilContext = erpcivilContext;
			}

		public bool AddEditAdmin(Admin admin)
		{
			if (admin.AdminId > 0)
			{
				var d = _erpcivilContext.Admins.Find(admin.AdminId);
			d.FirstName = admin.FirstName;
			d.LastName = admin.LastName;
			d.EmailId = admin.EmailId;
			d.MobNo = admin.MobNo;
			d.UserName = admin.UserName;
		    d.PasswordHash = admin.PasswordHash;
			d.OrganisationName = admin.OrganisationName;
			d.Address = admin.Address;
			d.Doj = admin.Doj;
			d.IsActive = admin.IsActive;
			

			}

			else
			{
				_erpcivilContext.Admins.Add(admin);
			}
			return _erpcivilContext.SaveChanges() > 0 ? true : false;

		}


		public Admin GetAdmin(int id)
		{
			var a =_erpcivilContext.Admins.Find(id);
			return a;
		}

		public bool DeleteAdmin(int id)
		{
			var s = _erpcivilContext.Admins.Find(id);
			_erpcivilContext.Remove(s);
			return _erpcivilContext.SaveChanges() > 0 ? true : false;
		}

		public List<Admin> GetAllAdmins()
		{
			return _erpcivilContext.Admins.ToList();
		}

		public Admin LoginCheck(string username, string password, out bool IsSuccess)
		{
			var y =_erpcivilContext.Admins.FirstOrDefault(x=>x.FirstName == username);
			if(y != null)
			{
				var passhash = Helper.EncodePassword(password, y.PasswordSalt);

				if(passhash == y.PasswordHash)
				{
					IsSuccess = true;
					return y;
				}
				else
				{
					IsSuccess = false;
				}

			}
			else
			{ 
				IsSuccess=false;
			}
			return null;

		}
	}
}
