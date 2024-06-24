using ERPCivil.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPCivil.Repository.Interface
{
   public interface IUserRepository
    {
        bool AddEditUser(User user);
       
       bool DeleteUser (User user);

        List<User> GetAllUsers();

        User User(int id);

    }
}
