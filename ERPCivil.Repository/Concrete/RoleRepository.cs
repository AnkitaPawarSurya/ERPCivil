using ERPCivil.DataEntity;
using ERPCivil.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPCivil.Repository.Concrete
{
    public class RoleRepository : IRoleRepository
    {
        private ErpcivilContext _erpcivilContext;

        public RoleRepository(ErpcivilContext erpcivilContext)
        {
            _erpcivilContext = erpcivilContext;
        }

         public bool AddEditRole(Role role)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRole(Role role)
        {
            throw new NotImplementedException();
        }
        public List<Role> GetAllRoles()
        {
            throw new NotImplementedException();
        }
        public Role GetRole(int id)
        {
            throw new NotImplementedException();
        }
    }
}
