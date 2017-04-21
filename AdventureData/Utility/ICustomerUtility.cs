namespace AdventureData.Models
{
    public interface ICustomerUtility
    {
        Customer CreateCustomer(Customer template);
        void DeleteCustomer(Customer productToDelete);
        System.Collections.Generic.List<Customer> FindCustomer(string query);
        Customer GetCustomer(int customerId);
        void UpdateCustomer(Customer productToUpdate);
    }
}