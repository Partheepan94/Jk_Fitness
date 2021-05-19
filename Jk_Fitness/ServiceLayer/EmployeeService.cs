using DataLayer;
using ServiceLayer.Email;
using ServiceLayer.Password;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class EmployeeService
    {
        private readonly UnitOfWork uow;
        WebResponce webResponce = null;
        private readonly IMailService mailService;

        public EmployeeService(UnitOfWork uow, IMailService mailService)
        {
            this.uow = uow;
            this.mailService = mailService;
        }
       
        public WebResponce ListBranches()
        {
            try
            {
                List<Branch> branch = uow.BranchRepository.GetAll().ToList();
                if (branch != null && branch.Count > 0)
                {
                    webResponce = new WebResponce()
                    {
                        Code = 1,
                        Message = "Success",
                        Data = branch
                    };
                }
                else {
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

        public WebResponce ListUserType()
        {
            try
            {
                List<UserType> userType = uow.UserTypeRepository.GetAll().ToList();
                if (userType != null && userType.Count > 0)
                {
                    webResponce = new WebResponce()
                    {
                        Code = 1,
                        Message = "Success",
                        Data = userType
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

        public WebResponce SaveEmployees(Employee employee)
        {
            try
            {
                PasswordGenerate password = new();
                var empl = uow.DbContext.Employees.Where(x=>x.Branch== employee.Branch.Trim()).OrderBy(x=>x.EmployeeId).Select(x=>x.EmployeeId).LastOrDefault();
                var branchCode = uow.DbContext.Branches.Where(x=>x.BranchName == employee.Branch.Trim()).Select(i=>i.BranchCode).FirstOrDefault();
                if (empl != null)
                {
                    double subs = double.Parse(empl.Split(' ')[1]);
                    double val = subs+ (double)0.0001;
                    employee.EmployeeId = branchCode.Split(' ')[0]+ " " + String.Format("{0:0.0000}", val);
                }
                else {
                    employee.EmployeeId = branchCode + "0001";
                }

                employee.FirstName = employee.FirstName.Trim();
                employee.LastName = employee.LastName.Trim();
                employee.Email = employee.Email.Trim();
                employee.PhoneNo = employee.PhoneNo.Trim();
                employee.Branch = employee.Branch.Trim();
                employee.UserType = employee.UserType.Trim();

                employee.Password = passwordGenerator();
                employee.IsFirstTime = true;

                employee.CreatedDate = DateTime.Now;
                employee.CreatedBy = "Parthi";
                employee.Password= password.Generate();
                employee.IsFirstTime = true;
                uow.EmployeeRepository.Insert(employee);
                uow.Save();

                var request = new MailRequest();
                request.ToEmail = employee.Email;
                request.Subject = "Password";
                request.Body = "Use this Password While Login system: "+ employee.Password;
                mailService.SendEmailAsync(request);

                webResponce = new WebResponce()
                {
                    Code = 1,
                    Message = "Success",
                    Data = employee
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

        public WebResponce ListEmployeeDetails()
        {
            try
            {
                List<Employee> employe = uow.EmployeeRepository.GetAll().ToList();
                if (employe != null && employe.Count > 0)
                {
                    webResponce = new WebResponce()
                    {
                        Code = 1,
                        Message = "Success",
                        Data = employe
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

        public WebResponce GetEmployeeById(string Id)
        {
            try
            {
                var employee = uow.EmployeeRepository.GetByID(Id);
                if (employee != null)
                {
                    webResponce = new WebResponce()
                    {
                        Code = 1,
                        Message = "Success",
                        Data = employee
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

        public WebResponce UpdateEmployees(Employee employee)
        {
            try
            {
                var Empl = uow.DbContext.Employees.Where(x => x.EmployeeId==employee.EmployeeId.Trim()).FirstOrDefault();
                if (Empl != null)
                {
                    Empl.Salutation = employee.Salutation;
                    Empl.FirstName = employee.FirstName.Trim();
                    Empl.LastName = employee.LastName.Trim();
                    Empl.Address = employee.Address;
                    Empl.Email = employee.Email.Trim();
                    Empl.PhoneNo = employee.PhoneNo.Trim();
                    Empl.Branch = employee.Branch.Trim();
                    Empl.UserType = employee.UserType.Trim();
                    Empl.Active = employee.Active;
                    Empl.MorningInTime = employee.MorningInTime;
                    Empl.MorningOutTime = employee.MorningOutTime;
                    Empl.EveningInTime = employee.EveningInTime;
                    Empl.EveningOutTime = employee.EveningOutTime;
                    Empl.ModifiedDate = DateTime.Now;
                    Empl.ModifiedBy = "Parthi";
                    uow.EmployeeRepository.Update(Empl);
                    uow.Save();

                    webResponce = new WebResponce()
                    {
                        Code = 1,
                        Message = "Success",
                        Data = employee
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

        public WebResponce DeleteEmployee(Employee employee)
        {
            try
            {
                var Empl = uow.DbContext.Employees.Where(x => x.EmployeeId == employee.EmployeeId.Trim()).FirstOrDefault();
                if (Empl != null)
                {
                    uow.EmployeeRepository.Delete(Empl);
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

        public WebResponce SearchEmployee(Employee employee)
        {
            try
            {
                List<Employee> Empl = uow.DbContext.Employees.Where(x => x.Branch == employee.Branch.Trim() && x.FirstName.Contains(employee.FirstName)).ToList();
                if (Empl != null && Empl.Count>0)
                {
                    webResponce = new WebResponce()
                    {
                        Code = 1,
                        Message = "Success",
                        Data=Empl
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
        public string passwordGenerator()
        {
            string allowedChars = "";

            allowedChars = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,";

            allowedChars += "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,";

            allowedChars += "1,2,3,4,5,6,7,8,9,0,!,@,#,$,%,&,?";

            char[] sep = { ',' };

            string[] arr = allowedChars.Split(sep);

            string passwordString = "";

            string temp = "";

            Random rand = new Random();

            for (int i = 0; i < 10; i++)

            {

                temp = arr[rand.Next(0, arr.Length)];

                passwordString += temp;

            }

            return passwordString;
        }

        //protected async Task SendMail(MailRequest request)
        //{
        //    try
        //    {
        //        mailService.SendEmailAsync(request);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

    }
}
