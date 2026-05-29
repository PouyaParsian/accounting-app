using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Repositories
{
    public interface IAccountingRepository
    {
        List<Accounting> GetAllTransaction(string transactionType);
        List<Accounting> GetTransactionByFilter(string filter, int customerID, int TypeID);
        Accounting GetTransactionById(int transactionId);
        bool InsertTransaction(Accounting transaction);
        bool UpdateTransaction(Accounting transaction);
        bool DeleteTransaction(Accounting transaction);
        bool DeleteTransaction(int transactionId);
    }
}
