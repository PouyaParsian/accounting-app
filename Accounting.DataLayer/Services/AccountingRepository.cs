using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;

namespace Accounting.DataLayer.Services
{
    class AccountingRepository : IAccountingRepository
    {
        Accounting_DBEntities db;
        public AccountingRepository(Accounting_DBEntities context)
        {
            db = context;
        }

        public bool DeleteTransaction(Accounting transaction)
        {
            try
            {
                db.Entry(transaction).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteTransaction(int transactionId)
        {
            try
            {
                var transaction = GetTransactionById(transactionId);
                DeleteTransaction(transaction);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Accounting> GetAllTransaction(string transactionType)
        {
            if (transactionType == "Recive")
            {
                return db.Accounting.Where(t => t.TypeID == 1).ToList();
            }
            else if (transactionType == "Payment")
            {
                return db.Accounting.Where(t => t.TypeID == 2).ToList();
            }
            else
            {
                return db.Accounting.ToList();
            }
        }

        public List<Accounting> GetTransactionByFilter(string filter, int customerID, int TypeID)
        {
            var typeID = db.Accounting.Where(t => t.TypeID == TypeID);
            if (customerID != 0)
            {
                var customerId = typeID.Where(t => t.CustomerID == customerID);
                return customerId.Where(t => t.Amount == filter || t.DateTime == filter || t.Description.Contains(filter)).ToList();
            }
            else
            {
                return typeID.Where(t => t.Amount == filter || t.DateTime == filter || t.Description.Contains(filter)).ToList();
            }
        }

        public Accounting GetTransactionById(int transactionId)
        {
            return db.Accounting.Find(transactionId);
        }

        public bool InsertTransaction(Accounting transaction)
        {
            try
            {
                db.Accounting.Add(transaction);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateTransaction(Accounting transaction)
        {
            try
            {
                db.Entry(transaction).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
