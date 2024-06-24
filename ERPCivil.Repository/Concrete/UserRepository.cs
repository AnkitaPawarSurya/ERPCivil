using ERPCivil.DataEntity;
using ERPCivil.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPCivil.Repository.Concrete
{
    public class UserRepository : IUserRepository
    {
        private ErpcivilContext _erpcivilcontext;

        public UserRepository(ErpcivilContext erpcivilContext)
        {
            _erpcivilcontext = erpcivilContext;
        }


        public bool AddEditUser(User user)
        {
            if(user.UserId>0)
            {
                var s= _erpcivilcontext.Users.Find(user.UserId);
                s.UserName = user.UserName;
                s.PasswordHash = user.PasswordHash;
                s.PasswordSalt= user.PasswordSalt;
                s.Name = user.Name;
                s.EmailId = user.EmailId;
                s.ContactNo = user.ContactNo;
                s.Address = user.Address;
                s.RoleId = user.RoleId;
				s.IsActive = user.IsActive;

			}
			else
			{
				_erpcivilcontext.Users.Add(user);
			}
			return _erpcivilcontext.SaveChanges() > 0 ? true : false;
		}

        public bool DeleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsers()
        {
		
	    	return _erpcivilcontext.Users.Include(Y=>Y.RoleName).ToList();
		
		}

        public User User(int id)
        {
            throw new NotImplementedException();
        }
    }
}
