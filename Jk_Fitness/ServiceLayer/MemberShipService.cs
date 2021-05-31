using DataLayer;
using DataLayer.Models;
using ServiceLayer.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class MemberShipService
    {
        private readonly UnitOfWork uow;
        WebResponce webResponce = null;
        private readonly IMailService mailService;

        public MemberShipService(UnitOfWork uow, IMailService mailService)
        {
            this.uow = uow;
            this.mailService = mailService;
        }

        public WebResponce SaveMemberShipDetails(MemberShip Member)
        {
            try
            {
                var MemId = uow.DbContext.MemberShips.Where(x => x.Branch == Member.Branch.Trim()).OrderBy(x => x.MemberId).Select(x => x.MemberId).LastOrDefault();
                var PackageDetails = uow.MembershipTypesRepository.GetByID(Member.MemberPackage);

                if (MemId != 0)
                {
                    Member.MemberId = (int)MemId + 1;
                }
                else {
                    int InitialRange = uow.DbContext.Branches.Where(x => x.BranchName == Member.Branch.Trim()).Select(x => x.MembershipInitialRangeFrom).FirstOrDefault();
                    Member.MemberId = InitialRange + 1;
                }
               
                Member.FirstName = Member.FirstName.Trim();
                Member.LastName = Member.LastName.Trim();
                Member.Gender = Member.Gender.Trim();
                Member.Branch = Member.Branch.Trim();
                Member.CreatedBy = Member.CreatedBy;
                Member.CreatedDate = DateTime.Now;
                
                uow.MembershipRepository.Insert(Member);
                uow.Save();

                var request = new MailRequest();
                request.ToEmail = Member.Email;
                request.Subject = "Welcome";

                StringBuilder body = new StringBuilder();

                body.AppendLine("<p style='line - height: 18px; font - family: verdana; font - size: 12px;'>Dear " + Member.FirstName + ",</p>");
                body.AppendLine("<p style='line - height: 18px; font - family: verdana; font - size: 12px;'>Welcome to JK Fitness!.</p>");
                body.AppendLine("<p style='line - height: 18px; font - family: verdana; font - size: 12px;'>Your Fitness Package:" + PackageDetails.MembershipName + "</p>Package Amount: &nbsp;" + PackageDetails.MembershipAmount + "<br /><br />");
                body.AppendLine("<p style='line - height: 18px; font - family: verdana; font - size: 12px;'>Regards,<br /> JK Fitness group </ p > ");

                request.Body = body.ToString();
                mailService.SendEmailAsync(request);
                webResponce = new WebResponce()
                {
                    Code = 1,
                    Message = "Success",
                    Data = Member
                };
            }
            catch (Exception ex)
            {
                webResponce = new WebResponce()
                {
                    Code = -1,
                    Message = ex.Message.ToString()
                };
            }
            return webResponce;
        }

        public WebResponce ListMemberShipDetails()
        {
            try
            {
                List<MemberShip> Member = uow.MembershipRepository.GetAll().ToList();
                if (Member != null && Member.Count > 0)
                {
                    webResponce = new WebResponce()
                    {
                        Code = 1,
                        Message = "Success",
                        Data = Member
                    };
                }
                else
                {
                    webResponce = new WebResponce()
                    {
                        Code = 0,
                        Message = "Seems Like Doesn't have Records!"
                    };
                }
            }
            catch (Exception ex)
            {
                webResponce = new WebResponce()
                {
                    Code = -1,
                    Message = ex.Message.ToString()
                };
            }
            return webResponce;
        }

        public WebResponce GetMemberShipDetailsById(int Id)
        {
            try
            {
                var Member = uow.MembershipRepository.GetByID(Id);
                if (Member != null)
                {
                    webResponce = new WebResponce()
                    {
                        Code = 1,
                        Message = "Success",
                        Data = Member
                    };
                }
                else
                {
                    webResponce = new WebResponce()
                    {
                        Code = 0,
                        Message = "Seems Like Doesn't have Records!"
                    };
                }
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


        public WebResponce UpdateMemberShipDetails(MemberShip member)
        {
            try
            {
                var Mem = uow.DbContext.MemberShips.Where(x => x.MemberId==member.MemberId).FirstOrDefault();
                if (Mem != null)
                {
                    Mem.FirstName = member.FirstName.Trim();
                    Mem.LastName = member.LastName.Trim();
                    Mem.Gender = member.Gender.Trim();
                    Mem.NIC = member.NIC.Trim();
                    Mem.Address1 = member.Address1.Trim();
                    Mem.Address2 = member.Address2.Trim();
                    Mem.ContactNo = member.ContactNo.Trim();
                    Mem.DateofBirth = member.DateofBirth;
                    Mem.Email = member.Email.Trim();
                    Mem.Branch = member.Branch.Trim();
                    Mem.Age = member.Age;
                    Mem.Height = member.Height;
                    Mem.Weight = member.Weight;
                    Mem.BMI = member.BMI;

                    if(Mem.MemberPackage != member.MemberPackage)
                    {
                        Mem.MemberPackage = member.MemberPackage;
                        var PackageDetails = uow.MembershipTypesRepository.GetByID(member.MemberPackage);

                        var request = new MailRequest();
                        request.ToEmail = Mem.Email;
                        request.Subject = "Membership Package Change";

                        StringBuilder body = new StringBuilder();

                        body.AppendLine("<p style='line - height: 18px; font - family: verdana; font - size: 12px;'>Dear " + Mem.FirstName + ",</p>");
                        body.AppendLine("<p style='line - height: 18px; font - family: verdana; font - size: 12px;'>Your package got change successfully!.</p>");
                        body.AppendLine("<p style='line - height: 18px; font - family: verdana; font - size: 12px;'>Your Fitness Package:" + PackageDetails.MembershipName + "</p>Package Amount: &nbsp;" + PackageDetails.MembershipAmount + "<br /><br />");
                        body.AppendLine("<p style='line - height: 18px; font - family: verdana; font - size: 12px;'>Regards,<br /> JK Fitness group </ p > ");

                        request.Body = body.ToString();
                        mailService.SendEmailAsync(request);

                    }

                    
                    Mem.Payment = member.Payment;
                    Mem.EmergencyContactNo = member.EmergencyContactNo.Trim();
                    Mem.RelationShip = member.RelationShip.Trim();
                    Mem.IntroducedBy = member.IntroducedBy.Trim();
                    Mem.Active = member.Active;
                    Mem.Smoking = member.Smoking;
                    Mem.Discomfort = member.Discomfort;
                    Mem.Cholesterol = member.Cholesterol;
                    Mem.Herina = member.Herina;
                    Mem.Diabets = member.Diabets;
                    Mem.Pain = member.Pain;
                    Mem.Complaint = member.Complaint;
                    Mem.Incorrigible = member.Incorrigible;
                    Mem.Doctors = member.Doctors;
                    Mem.Pregnant = member.Pregnant;
                    Mem.Aliments = member.Aliments;
                    Mem.Surgery = member.Surgery;
                    Mem.Pressure = member.Pressure;
                    Mem.Trace = member.Trace;
                    Mem.Musele = member.Musele;
                    Mem.Fat = member.Fat;
                    Mem.Body = member.Body;
                    Mem.Fitness = member.Fitness;
                    Mem.Athletics = member.Athletics;
                    Mem.JoinDate = member.JoinDate;
                    
                    Mem.ModifiedDate = DateTime.Now;
                    Mem.ModifiedBy = member.ModifiedBy;
                    uow.MembershipRepository.Update(Mem);
                    uow.Save();

                    webResponce = new WebResponce()
                    {
                        Code = 1,
                        Message = "Success",
                        Data = Mem
                    };
                }
                else
                {
                    webResponce = new WebResponce()
                    {
                        Code = 0,
                        Message = "Seems Like Doesn't have Records!"
                    };
                }

            }
            catch (Exception ex)
            {
                webResponce = new WebResponce()
                {
                    Code = -1,
                    Message = ex.Message.ToString()
                };
            }
            return webResponce;
        }

        public WebResponce DeleteMemberShpDetails(MemberShip Member)
        {
            try
            {
                var MeM = uow.DbContext.MemberShips.Where(x => x.MemberId==Member.MemberId).FirstOrDefault();
                if (MeM != null)
                {
                    uow.MembershipRepository.Delete(MeM);
                    uow.Save();
                    webResponce = new WebResponce()
                    {
                        Code = 1,
                        Message = "Success"
                    };
                }
                else
                {
                    webResponce = new WebResponce()
                    {
                        Code = 0,
                        Message = "Seems Like Doesn't have Records!"
                    };
                }
            }
            catch (Exception ex)
            {
                webResponce = new WebResponce()
                {
                    Code = -1,
                    Message = ex.Message.ToString()
                };
            }
            return webResponce;
        }

        public WebResponce SearchMemberShipDetails(MemberShip member)
        {
            try
            {
                List<MemberShip> MeM = uow.DbContext.MemberShips.Where(x => x.Branch == member.Branch.Trim() && x.FirstName.Contains(member.FirstName)).ToList();
                if (MeM != null && MeM.Count > 0)
                {
                    webResponce = new WebResponce()
                    {
                        Code = 1,
                        Message = "Success",
                        Data = MeM
                    };
                }
                else
                {
                    webResponce = new WebResponce()
                    {
                        Code = 0,
                        Message = "Seems Like Doesn't have Records!"
                    };
                }
            }
            catch (Exception ex)
            {
                webResponce = new WebResponce()
                {
                    Code = -1,
                    Message = ex.Message.ToString()
                };
            }
            return webResponce;
        }


    }
}
