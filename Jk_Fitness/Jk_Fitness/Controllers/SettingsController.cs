using DataLayer;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jk_Fitness.Controllers
{
    public class SettingsController : Controller
    {
        private readonly SettingsService Setting;
        WebResponce webResponce = null;

        public SettingsController(SettingsService Setting) {
            this.Setting = Setting;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Branch()
        {
            return View();
        }

        [HttpPost]
        public WebResponce SaveBranch([FromBody] Branch branch)
        {
            try
            {
                webResponce = Setting.SaveBranch(branch);
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
        public WebResponce GetBranchDetails()
        {
            try
            {
                webResponce = Setting.ListBranchDetails();
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
        public WebResponce GetBranchById([FromBody] Branch branch)
        {
            try
            {
                webResponce = Setting.GetBranchById(branch.Id);
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
        public WebResponce Updatebranch([FromBody] Branch branch)
        {
            try
            {
                webResponce = Setting.UpdateBranch(branch);
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
        public WebResponce DeleteBranch([FromBody] Branch branch)
        {
            try
            {
                webResponce = Setting.DeleteBranch(branch);
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
        public WebResponce SearchBranch([FromBody] Branch branch)
        {
            try
            {
                webResponce = Setting.SearchBranch(branch);
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
