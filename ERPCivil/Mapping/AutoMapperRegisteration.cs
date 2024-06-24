using AutoMapper;
using ERPCivil.BusinessEntity;
using ERPCivil.DataEntity;

namespace ERPCivil.Mapping
{
	public class AutoMapperRegisteration : Profile
	{
		public AutoMapperRegisteration()
		{
			CreateMap<AdminViewModel,Admin>().ReverseMap();

			CreateMap<UserViewModel, User>().ReverseMap().
				ForMember(y => y.RoleName, op => op.MapFrom(p => p.RoleName.Designation));
		}
	}
}
