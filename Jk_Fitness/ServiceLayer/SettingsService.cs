using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class SettingsService
    {
        private readonly UnitOfWork uow;
        WebResponce webResponce = null;

        public SettingsService(UnitOfWork uow)
        {
            this.uow = uow;
        }

        public WebResponce SaveBranch(Branch branch)
        {
            try
            {
                var BranchCode = uow.DbContext.Branches.OrderBy(x => x.Id).Select(x => x.BranchCode).LastOrDefault();
                if (BranchCode != null)
                {
                    double subs = double.Parse(BranchCode.Split(' ')[1]);
                    double val = subs + (double)1;
                    branch.BranchCode = BranchCode.Split(' ')[0] + " " + String.Format("{0:0.0}", val);
                }
                else
                {
                    branch.BranchCode = "JKF 1.0";
                }
                branch.BranchName = branch.BranchName.Trim();
                branch.CreatedDate = DateTime.Now;
                branch.CreatedBy = branch.CreatedBy;
                uow.BranchRepository.Insert(branch);
                uow.Save();

                webResponce = new WebResponce()
                {
                    Code = 1,
                    Message = "Success",
                    Data = branch
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

        public WebResponce ListBranchDetails()
        {
            try
            {
                List<Branch> branches = uow.BranchRepository.GetAll().ToList();

                if (branches != null && branches.Count > 0)
                {
                    List<Employee> employees = uow.EmployeeRepository.GetAll().ToList();
                    foreach (var branch in branches)
                    {
                        branch.IsDeleteble = (employees.Where(x => x.Branch == branch.BranchName).Count() > 0) ? false : true;
                    }

                    webResponce = new WebResponce()
                    {
                        Code = 1,
                        Message = "Success",
                        Data = branches
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

        public WebResponce GetBranchById(int Id)
        {
            try
            {
                var branch = uow.BranchRepository.GetByID(Id);
                if (branch != null)
                {
                    webResponce = new WebResponce()
                    {
                        Code = 1,
                        Message = "Success",
                        Data = branch
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

        public WebResponce UpdateBranch(Branch branch)
        {
            try
            {
                var Brch = uow.DbContext.Branches.Where(x => x.Id == branch.Id).FirstOrDefault();
                if (Brch != null)
                {
                    Brch.BranchName = branch.BranchName.Trim();
                    Brch.MembershipInitialRangeFrom = branch.MembershipInitialRangeFrom;
                    Brch.MembershipInitialRangeTo = branch.MembershipInitialRangeTo;
                    Brch.MembershipActiveMonthRange = branch.MembershipActiveMonthRange;

                    Brch.ModifiedDate = DateTime.Now;
                    Brch.ModifiedBy = branch.ModifiedBy;
                    uow.BranchRepository.Update(Brch);
                    uow.Save();

                    webResponce = new WebResponce()
                    {
                        Code = 1,
                        Message = "Success",
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

        public WebResponce DeleteBranch(Branch branch)
        {
            try
            {
                var Brch = uow.DbContext.Branches.Where(x => x.Id == branch.Id).FirstOrDefault();
                if (Brch != null)
                {
                    uow.BranchRepository.Delete(Brch);
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

        public WebResponce SearchBranch(Branch branch)
        {
            try
            {
                List<Branch> Brch = uow.DbContext.Branches.Where(x => x.BranchCode.Contains(branch.BranchCode) && x.BranchName.Contains(branch.BranchName)).ToList();
                if (Brch != null && Brch.Count > 0)
                {
                    webResponce = new WebResponce()
                    {
                        Code = 1,
                        Message = "Success",
                        Data = Brch
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
