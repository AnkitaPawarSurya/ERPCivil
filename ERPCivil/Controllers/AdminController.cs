using ERPCivil.BusinessEntity;
using ERPCivil.BusinessServices.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ERPCivil.Controllers
{
	public class AdminController : Controller
	{
		IAdminService _adminService;
		
		public AdminController(IAdminService adminService)
		{
		     _adminService = adminService;
			
		}

		public IActionResult Admin()
		{
			return View();
		}


		public JsonResult GetData()
		{
			var a = _adminService.GetAllAdmins();
			return Json(new { data = a });
		}

		//public JsonResult AddUser(UserViewModel userView)
		//{
		//	var b = _userservice.AddEditUser(userView);
		//	return Json(new { result = b, message = "User Added Successfully" });
		//}




	}
}
