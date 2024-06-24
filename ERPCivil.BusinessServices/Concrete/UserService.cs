using AutoMapper;
using ERPCivil.BusinessEntity;
using ERPCivil.BusinessServices.Interface;
using ERPCivil.DataEntity;
using ERPCivil.Repository.Concrete;
using ERPCivil.Repository.Interface;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPCivil.BusinessServices.Concrete
{

	public class UserService : IUserService
	{
		private IUserRepository _userRepository;

			private IMapper mapper;
		public UserService(IUserRepository userRepository, IMapper _mapper)
		{
			_userRepository = userRepository;
			mapper = _mapper;
		}

		

		public bool AddEditUser(UserViewModel userViewModel)
		{
			var d = mapper.Map<User>(userViewModel);
			return _userRepository.AddEditUser(d);

		}

		List<UserViewModel> IUserService.GetUser()
		{
			var n = _userRepository.GetAllUsers();
			return mapper.Map<List<UserViewModel>>(n);
		}
	}
}
