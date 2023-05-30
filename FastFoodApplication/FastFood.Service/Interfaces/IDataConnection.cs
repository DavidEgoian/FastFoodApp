using FastFood.Models;
using FastFood.Service;

namespace FastFood.Service.Interfaces
{
    public interface IDataConnection
    {
        Task<General> GetBalance();
        //
        Task<List<Employee>> GetAllEmployee();
        Task<Employee> GetEmployeeByPin(string pin);
        Task<Employee> AddNewEmployee(Employee model);
        //
        Task<List<Product>> GetAllProducts();
        Task<Product> GetProductByTitle(string title);
        Task<Product> AddNewProduct(Product model);
    }
}
