using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ServiceLayer;
using ServiceLayer.Password;
using ServiceLayer.VMmodel;

namespace Jk_Fitness.Controllers
{
    [ValidCookie]
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
        public WebResponce SaveEmployees(EmployeeVM files)
        {
            try
            {
                Employee employe = JsonConvert.DeserializeObject<Employee>(files.Employee);
                if (files.file !=null)
                {
                    using (var ms = new MemoryStream())
                    {
                        files.file.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        employe.Image = fileBytes; 
                    }
                }
                employe.CreatedBy = Crypto.DecryptString(Request.Cookies["jkfitness.cookie"]); 
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
        public WebResponce UpdateEmployees(EmployeeVM files)
        {
            try
            {
                Employee employe = JsonConvert.DeserializeObject<Employee>(files.Employee);
                if (files.file != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        files.file.CopyTo(ms);
                        var fileBytes = ms.ToArray();
                        employe.Image = fileBytes; 
                    }
                }
                employe.ModifiedBy = Crypto.DecryptString(Request.Cookies["jkfitness.cookie"]);
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

        #region SalaryManagement
        public IActionResult Salary()
        {
            return View();
        }


        [HttpPost]
        public WebResponce UpdateSalary([FromBody] Employee employe)
        {
            try
            {
                employe.ModifiedBy = Crypto.DecryptString(Request.Cookies["jkfitness.cookie"]);
                webResponce = employee.UpdateSalary(employe);
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
        #endregion
    }
}
