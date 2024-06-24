using AutoMapper;
using ERPCivil.BusinessEntity;
using ERPCivil.BusinessServices.Interface;
using ERPCivil.Common;
using ERPCivil.DataEntity;
using ERPCivil.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ERPCivil.BusinessServices.Concrete
{
	internal class AdminService : IAdminService
	{
		private IAdminRepository _adminRepository;

		private IMapper mapper;
		public AdminService(IAdminRepository adminRepository,IMapper _mapper)
		{
			_adminRepository = adminRepository;
			mapper = _mapper;
		}

		public bool AddEditAdmin(AdminViewModel admin)
		{
			

			var d =mapper.Map<Admin>(admin);
			return _adminRepository.AddEditAdmin(d);
		}

		
		public bool DeleteAdmin(int id)
		{
			return _adminRepository.DeleteAdmin(id);
		}

		public AdminViewModel GetAdmin(int id)
		{
			var m =_adminRepository.GetAdmin(id);
			return mapper.Map<AdminViewModel>(m);
		}

		public List<AdminViewModel> GetAllAdmins()
		{
			var r=_adminRepository.GetAllAdmins();
			return mapper.Map<List<AdminViewModel>>(r);	
		}

		public bool AdminRegisteration(AdminViewModel adminviewmodel)
		{
			var k = mapper.Map<Admin>(adminviewmodel);
			var salt = Helper.GeneratePassword(10);

			k.PasswordSalt = salt;
			k.PasswordHash = Helper.EncodePassword(adminviewmodel.Password,salt);
			return _adminRepository.AddEditAdmin(k);
		}

		public AdminViewModel LoginCheck(string username, string password, out bool IsSuccess)
		{
			var d= _adminRepository.LoginCheck(username, password, out IsSuccess);
			return mapper.Map<AdminViewModel>(d);
		}
	}
}
