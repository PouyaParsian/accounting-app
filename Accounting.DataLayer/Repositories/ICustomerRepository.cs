using System.Collections.Generic;
using Accounding.ViewModels;

namespace Accounting.DataLayer.Repositories
{
    public interface ICustomerRepository
    {
        List<Customers> GetAllCustomers();
        List<Customers> GetCustomerByFilter(string parameter);
        Customers GetCustomerById(int customerId);
        string GetCustomerNameById(int customerId);
        List<ListCustomerViewModel> GetCustomersName();
        bool InsertCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);
        bool DeleteCustomer(Customers customer);
        bool DeleteCustomer(int customerId);
    }
}
