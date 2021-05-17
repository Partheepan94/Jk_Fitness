using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class UnitOfWork : IDisposable
    {
        private readonly DatabaseContext context;

        public UnitOfWork(DatabaseContext context)
        {
            this.context = context;
        }

        private GenericRepository<Branch> branchRepository;
        private GenericRepository<UserType> userTypeRepository;
        private GenericRepository<Employee> employeeRepository;

        public GenericRepository<Branch> BranchRepository
        {
            get 
            {
                try
                {
                    if (this.branchRepository == null)
                    {
                        this.branchRepository = new GenericRepository<Branch>(context);
                    }
                    return branchRepository;
                }
                catch (Exception ex)
                {
                    ex.ToString();
                    throw;
                }
            }
        }

        public GenericRepository<UserType> UserTypeRepository
        {
            get
            {
                try
                {
                    if (this.userTypeRepository == null)
                    {
                        this.userTypeRepository = new GenericRepository<UserType>(context);
                    }
                    return userTypeRepository;
                }
                catch (Exception ex)
                {
                    ex.ToString();
                    throw;
                }
            }
        }

        public GenericRepository<Employee> EmployeeRepository
        {
            get
            {
                try
                {
                    if (this.employeeRepository == null)
                    {
                        this.employeeRepository = new GenericRepository<Employee>(context);
                    }
                    return employeeRepository;
                }
                catch (Exception ex)
                {
                    ex.ToString();
                    throw;
                }
            }
        }
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~UnitOfWork()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public DatabaseContext DbContext { get { return context; } }
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
