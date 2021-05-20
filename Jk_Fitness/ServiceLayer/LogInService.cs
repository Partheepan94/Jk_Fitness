using DataLayer;
using ServiceLayer.Password;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class LogInService
    {
        private readonly UnitOfWork uow;
        WebResponce webResponce = null;

        public LogInService(UnitOfWork uow)
        {
            this.uow = uow;
        }

        public WebResponce ListLogInInfo(Employee employee)
        {
            try
            {
                var Empl = uow.DbContext.Employees.Where(x => x.Email == employee.Email.Trim() && x.Active == true).FirstOrDefault();
                if (Empl != null)
                {
                    if (string.Compare(Crypto.Hash(employee.Password.Trim()), Empl.Password) == 0)
                    {
                        webResponce = new WebResponce()
                        {
                            Code = 1,
                            Message = "Success",
                            Data = Empl
                        };
                    }
                    else
                    {
                        webResponce = new WebResponce()
                        {
                            Code = 0,
                            Message = "Invalid",
                        };
                    }
                }
                else
                {
                    webResponce = new WebResponce()
                    {
                        Code = 0,
                        Message = "Invalid"
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

        public WebResponce ConfirmPassword(Employee employee)
        {
            try
            {
                var Empl = uow.DbContext.Employees.Where(x => x.EmployeeId == employee.EmployeeId.Trim()).FirstOrDefault();
                if (Empl != null)
                {
                    if (string.Compare(Crypto.Hash(employee.Password.Trim()), Empl.Password) == 0)
                    {
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
                            Message = "Invalid",
                        };
                    }
                }
                else
                {
                    webResponce = new WebResponce()
                    {
                        Code = 0,
                        Message = "Invalid"
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

        public WebResponce UpdatePassword(Employee employee)
        {
            try
            {
                var Empl = uow.DbContext.Employees.Where(x => x.EmployeeId == employee.EmployeeId.Trim()).FirstOrDefault();
                if (Empl != null)
                {
                    Empl.Password = Crypto.Hash(employee.Password.Trim());
                    Empl.IsFirstTime = false;
                    Empl.ModifiedDate = DateTime.Now;
                    Empl.ModifiedBy = "Parthi";
                    uow.EmployeeRepository.Update(Empl);
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
                        Message = "Invalid"
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
