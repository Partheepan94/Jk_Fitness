using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;

namespace Jk_Fitness.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly EmployeeService employee;
        WebResponce webResponce = null;
        public EmployeeController(EmployeeService employee)
        {
            this.employee = employee;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpGet]
        public WebResponce GetBranchDetails()
        {
            try
            {
                webResponce = employee.ListBranches();
                return webResponce;
            }
            catch (Exception Ex)
            {
                webResponce = new WebResponce()
                {
                    Code = -1,
                    Message = Ex.Message
                };
                return webResponce;
            }
        }

        [HttpGet]
        public WebResponce GetUserTypeDetails()
        {
            try
            {
                webResponce = employee.ListUserType();
                return webResponce;
            }
            catch (Exception Ex)
            {
                webResponce = new WebResponce()
                {
                    Code = -1,
                    Message = Ex.Message
                };
                return webResponce;
            }
        }

        [HttpPost]
        public WebResponce SaveEmployees([FromBody] Employee employe)
        {
            try
            {
                employe.CreatedBy = HttpContext.Session.GetString("UserId");
                webResponce = employee.SaveEmployees(employe);
                return webResponce;
            }
            catch (Exception Ex)
            {
                webResponce = new WebResponce()
                {
                    Code = -1,
                    Message = Ex.Message
                };
                return webResponce;
            }
        }

        [HttpGet]
        public WebResponce GetEmployeeDetails()
        {
            try
            {
                webResponce = employee.ListEmployeeDetails();
                return webResponce;
            }
            catch (Exception Ex)
            {
                webResponce = new WebResponce()
                {
                    Code = -1,
                    Message = Ex.Message
                };
                return webResponce;
            }
        }

        [HttpPost]
        public WebResponce GetEmployeeById([FromBody] Employee employe)
        {
            try
            {
                webResponce = employee.GetEmployeeById(employe.EmployeeId);
                return webResponce;
            }
            catch (Exception Ex)
            {
                webResponce = new WebResponce()
                {
                    Code = -1,
                    Message = Ex.Message
                };
                return webResponce;
            }
        }

        [HttpPost]
        public WebResponce UpdateEmployees([FromBody] Employee employe)
        {
            try
            {
                employe.ModifiedBy = HttpContext.Session.GetString("UserId");
                webResponce = employee.UpdateEmployees(employe);
                return webResponce;
            }
            catch (Exception Ex)
            {
                webResponce = new WebResponce()
                {
                    Code = -1,
                    Message = Ex.Message
                };
                return webResponce;
            }
        }

        [HttpPost]
        public WebResponce DeleteEmployees([FromBody] Employee employe)
        {
            try
            {
                webResponce = employee.DeleteEmployee(employe);
                return webResponce;
            }
            catch (Exception Ex)
            {
                webResponce = new WebResponce()
                {
                    Code = -1,
                    Message = Ex.Message
                };
                return webResponce;
            }
        }

        [HttpPost]
        public WebResponce SearchEmployees([FromBody] Employee employe)
        {
            try
            {
                webResponce = employee.SearchEmployee(employe);
                return webResponce;
            }
            catch (Exception Ex)
            {
                webResponce = new WebResponce()
                {
                    Code = -1,
                    Message = Ex.Message
                };
                return webResponce;
            }
        }
    }
}
