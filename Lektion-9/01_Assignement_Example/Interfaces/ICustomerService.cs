﻿namespace _01_Assignement_Example.Interfaces
{
    public interface ICustomerService
    {
        Task AddCustomerAsync(ICustomer customer);
        IEnumerable<ICustomer> GetAllCustomers();
        ICustomer GetOneCustomer(string email);
        void RemoveCustomer(string email);
    }
}