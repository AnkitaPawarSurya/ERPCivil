using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPCivil.BusinessEntity
{
	public class UserViewModel
	{
		public int UserId { get; set; }

		public string? UserName { get; set; }

		public string? PasswordHash { get; set; }

		public string? PasswordSalt { get; set; }

		public string? Name { get; set; }

		public string? EmailId { get; set; }

		public string? ContactNo { get; set; }

		public string? Address { get; set; }

		public int? RoleName { get; set; }

		public bool? IsActive { get; set; }


	}
}
