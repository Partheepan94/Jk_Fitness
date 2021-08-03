﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;
using ServiceLayer.Password;
using ServiceLayer.VMmodel;

namespace Jk_Fitness.Controllers
{
    [ValidCookie]
    public class MembershipController : Controller
    {
        private readonly MemberShipService MemberShip;
        WebResponce webResponce = null;

        public MembershipController(MemberShipService MemberShip)
        {
            this.MemberShip = MemberShip;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public WebResponce SaveMember(MemberShip Member)
        {
            try
            {
                Member.CreatedBy = Crypto.DecryptString(Request.Cookies["jkfitness.cookie"]);
                webResponce = MemberShip.SaveMemberShipDetails(Member);
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
        public WebResponce GetMemberDetails()
        {
            try
            {
                webResponce = MemberShip.ListMemberShipDetails(Crypto.DecryptString(Request.Cookies["jkfitness.cookie"]));
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
        public WebResponce GetMemberShipById([FromBody] MemberShip Member)
        {
            try
            {
                webResponce = MemberShip.GetMemberShipDetailsById(Member.MemberId);
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
        public WebResponce UpdateMemberShip( MemberShip Member)
        {
            try
            {
                Member.ModifiedBy = Crypto.DecryptString(Request.Cookies["jkfitness.cookie"]);
                webResponce = MemberShip.UpdateMemberShipDetails(Member);
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
        public WebResponce DeleteMemberShip([FromBody] MemberShip member)
        {
            try
            {
                webResponce = MemberShip.DeleteMemberShpDetails(member);
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
        public WebResponce SearchMembers([FromBody] MemberShip member)
        {
            try
            {
                webResponce = MemberShip.SearchMemberShipDetails(member);
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
                webResponce = MemberShip.ListBranches(Crypto.DecryptString(Request.Cookies["jkfitness.cookie"]));
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

        #region MembersAttendance

        public IActionResult MembershipAttendance()
        {
            return View();
        }

        [HttpGet]
        public WebResponce GetMemberShipAttendanceDetails()
        {
            try
            {
                webResponce = MemberShip.ListMemberShipAttendanceDetails();
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
        public WebResponce LoadMemberShipAttendanceDetails(AttendancesVM attendances)
        {
            try
            {
                webResponce = MemberShip.LoadMemberShipAttendanceDetails(attendances);
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
        public WebResponce SaveMemberAttendance(MembersAttendance Attendance)
        {
            try
            {
                Attendance.CreatedBy = Crypto.DecryptString(Request.Cookies["jkfitness.cookie"]);
                webResponce = MemberShip.SaveMemberShipAttendance(Attendance);
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
        public WebResponce UpdateMemberAttendance(MembersAttendance Attendance)
        {
            try
            {
                Attendance.ModifiedBy = Crypto.DecryptString(Request.Cookies["jkfitness.cookie"]);
                webResponce = MemberShip.UpdateMemberShipAttendance(Attendance);
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
        public WebResponce DeleteMemberAttendance([FromBody] MembersAttendance Attendance)
        {
            try
            {
                webResponce = MemberShip.DeleteMemberAttendance(Attendance);
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
