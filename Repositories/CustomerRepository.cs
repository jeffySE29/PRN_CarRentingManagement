using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;

namespace Repositories
{
    public class CustomerRepository:ICustomerRepository
    {
        public Customer CheckLogin(string email, string password)
            => CustomerDAO.Instance.CheckLogin(email, password);
        public List<Customer> GetCustomersList()
            => CustomerDAO.Instance.GetCustomersList();
        public Customer GetCustomerById(int? id)
            => CustomerDAO.Instance.GetCustomerById(id);
        public void CreateCustomer(Customer cusInfo)
            => CustomerDAO.Instance.CreateCustomer(cusInfo);
        public void UpdateCustomer(Customer cusInfo)
            => CustomerDAO.Instance.UpdateCustomer(cusInfo);
        public void DeleteCustomer(Customer cusInfo)
            => CustomerDAO.Instance.DeleteCustomer(cusInfo);
        public int GetIdOfCustomerByEmail(string email)
            => CustomerDAO.Instance.GetIdOfCustomerByEmail(email);
        public int GetCustomerMaxId()
            => CustomerDAO.Instance.GetCustomerMaxId();
    }
}
