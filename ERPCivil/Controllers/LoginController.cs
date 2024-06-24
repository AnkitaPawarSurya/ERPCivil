using ERPCivil.BusinessEntity;
using ERPCivil.BusinessServices.Interface;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ERPCivil.Controllers
{
	public class LoginController : Controller
	{
		private readonly IAdminService _adminService;

		public LoginController(IAdminService adminService)
		{

			_adminService = adminService;

		}


	
		public IActionResult Login()
		{
			return View();
		}



		[HttpPost]
		public IActionResult Login(LoginViewModel loginViewModel)
		{
			var g = _adminService.LoginCheck(loginViewModel.FirstName, loginViewModel.Password, out bool IsSuccess);

			if (!IsSuccess)
			{
				ViewBag.Errormsg = "Invalid Username and Password";
			}
			else
			{
				var claims = new List<Claim>()
						{
							new Claim(ClaimTypes.NameIdentifier, Convert.ToString(g.LastName)),
							new Claim(ClaimTypes.Name, g.EmailId)

						};

				var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
				//Initialize a new instance of the ClaimsPrincipal with ClaimsIdentity    
				var principal = new ClaimsPrincipal(identity);
				//SignInAsync is a Extension method for Sign in a principal for the specified scheme.    
				HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties()
				{
					IsPersistent = false,

				});

				return RedirectToAction("Admin", "Admin");
			}
			return View(loginViewModel);
		}
	}
}
