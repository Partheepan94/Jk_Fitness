using DataLayer;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using System.Runtime.Serialization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Jk_Fitness.Controllers
{
    public class LoginController : Controller
    {
        private readonly LogInService logInService;
        WebResponce webResponce = null;
        public LoginController(LogInService logInService)
        {
            this.logInService = logInService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult<WebResponce> ValidateLogIn([FromBody] Employee employe)
        {
            webResponce = logInService.ListLogInInfo(employe);
            if(webResponce.Code == 1)
            {
                var JkfitnessClaims = new List<Claim>() {
                new Claim(ClaimTypes.Name,((Employee)webResponce.Data).FirstName),
                new Claim("Email",((Employee)webResponce.Data).Email),
                new Claim("EmployeeId",((Employee)webResponce.Data).EmployeeId)
                };
                //var JkfitnessIdentity = new ClaimsIdentity(JkfitnessClaims, "Jkfitness Identity");
                var JkfitnessIdentity = new ClaimsIdentity(JkfitnessClaims, CookieAuthenticationDefaults.AuthenticationScheme);
                //var UserPrincipal = new ClaimsPrincipal(new[] { JkfitnessIdentity });
                //HttpContext.SignInAsync(UserPrincipal);
                var authProperties = new AuthenticationProperties
                {
                    ExpiresUtc = DateTime.UtcNow.AddMinutes(20)
                };
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(JkfitnessIdentity), authProperties);
            }
            return webResponce;
        }

        [HttpPost]
        public ActionResult<WebResponce> ConfirmPassword([FromBody] Employee employe)
        {
            webResponce = logInService.ConfirmPassword(employe);
            return webResponce;
        }

        [HttpPost]
        public ActionResult<WebResponce> UpdatePassword([FromBody] Employee employe)
        {
            employe.ModifiedBy = User.FindFirst("EmployeeId").Value;
            webResponce = logInService.UpdatePassword(employe);
            return webResponce;
        }

        [HttpGet]
        public ActionResult<WebResponce> SignOutLogin()
        {
            try
            {
                HttpContext.SignOutAsync();
                webResponce = new WebResponce()
                {
                    Code = 1,
                    Message = "Success"
                };
                return webResponce;
            }
            catch (Exception ex)
            {
                webResponce = new WebResponce()
                {
                    Code = -1,
                    Message = ex.Message.ToString()
                };
                return webResponce;
            }
        }
    }
}
