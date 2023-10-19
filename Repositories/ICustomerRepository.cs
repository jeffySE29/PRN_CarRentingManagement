using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICustomerRepository
    {
        Customer CheckLogin(string email, string password);
        List<Customer> GetCustomersList();
        Customer GetCustomerById(int? id);
        void CreateCustomer(Customer cusInfo);
        void UpdateCustomer(Customer cusInfo);
        void DeleteCustomer(Customer cusInfo);

        int GetIdOfCustomerByEmail(string email);

        int GetCustomerMaxId();
    }
}
