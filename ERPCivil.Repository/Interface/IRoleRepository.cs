using ERPCivil.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPCivil.Repository.Interface
{
    public interface IRoleRepository
    {
        bool AddEditRole(Role role);

        bool DeleteRole(Role role); 

       List<Role> GetAllRoles();

       Role GetRole(int id);


    }
}
