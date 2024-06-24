using ERPCivil.BusinessEntity;
using ERPCivil.BusinessServices.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ERPCivil.Controllers
{
	public class UserController : Controller
	{
		private IUserService _userService;


		public UserController(IUserService userService)
		{
			_userService = userService;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public JsonResult GetData()
		{
			var a = _userService.GetUser();
			return Json(new { data = a });
		}

		public IActionResult AddUser()
		{
			return View();
		}




		[HttpPost]
		public IActionResult AddUser(UserViewModel userView)
		{
			var b = _userService.AddEditUser(userView);
			return Json(new { result = b, message = "User Added Successfully" });
		}

	}
}
