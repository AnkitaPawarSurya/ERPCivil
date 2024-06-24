using ERPCivil.BusinessEntity;
using ERPCivil.BusinessServices.Interface;
using Microsoft.AspNetCore.Mvc;

namespace ERPCivil.Controllers
{
	public class RegisterationController : Controller
	{
		private IAdminService _adminservice;

		public RegisterationController(IAdminService adminservice)
		{
			_adminservice = adminservice;
		}

		[HttpGet]
		public IActionResult Registeration()
		{
			return View("Registeration");
		}

		[HttpPost]
		public IActionResult Registeration(AdminViewModel adminViewModel)
		{
			var c = _adminservice.AdminRegisteration(adminViewModel);
			return RedirectToAction("login","login");

		}
	}
}
