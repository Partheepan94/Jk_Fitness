using DataLayer;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            webResponce = logInService.UpdatePassword(employe);
            return webResponce;
        }
    }
}
