﻿using DataLayer;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using System.Runtime.Serialization;

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
                HttpContext.Session.SetString("UserId", ((Employee)webResponce.Data).EmployeeId);
                HttpContext.Session.SetString("FirstName", ((Employee)webResponce.Data).FirstName);
                HttpContext.Session.SetString("Email", ((Employee)webResponce.Data).Email);
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
            employe.ModifiedBy = HttpContext.Session.GetString("UserId");
            webResponce = logInService.UpdatePassword(employe);
            return webResponce;
        }

        [HttpGet]
        public ActionResult<WebResponce> SignOutLogin()
        {
            try
            {
                HttpContext.Session.Clear();
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
