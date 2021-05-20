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
        private readonly EmployeeService employee;
        WebResponce webResponce = null;
        public LoginController(EmployeeService employee)
        {
            this.employee = employee;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult<WebResponce> ValidateLogIn([FromBody] Employee employe)
        {
            webResponce = employee.ListLogInInfo(employe);
            return webResponce;
        }
    }
}
