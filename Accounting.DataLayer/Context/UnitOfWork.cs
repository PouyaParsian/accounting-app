using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;
using Accounting.Utility;
using System;

namespace Accounting.DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        Accounting_DBEntities db = new Accounting_DBEntities();
        private ICustomerRepository _customerRepository;
        private void MessageBox(string messageBoxText)
        {
            CustomMessageBox messageBox = new CustomMessageBox();
            messageBox.lblText = messageBoxText;
            messageBox.ShowDialog();
        }
        public ICustomerRepository CustomerRepository
        {
            get
            {
                if(_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(db);
                }
                return _customerRepository;
            }
        }
        private IAccountingRepository _accuntingRepository;
        public IAccountingRepository AccountingRepository
        {
            get
            {
                if (_accuntingRepository == null)
                {
                    _accuntingRepository = new AccountingRepository(db);
                }
                return _accuntingRepository;
            }
        }
        public bool Save()
        {
            try
            {
                db.SaveChanges();
                MessageBox("عملیات با موفقیت انجام شد");
                return true;
            }
            catch
            {
                MessageBox("!مشکلی پیش آمده است");
                return false;
            }
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
