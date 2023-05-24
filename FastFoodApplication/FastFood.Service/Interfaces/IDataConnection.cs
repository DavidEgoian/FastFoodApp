using FastFood.Models;
using FastFood.Service;

namespace FastFood.Service.Interfaces
{
    public interface IDataConnection
    {
        Task<General> GetBalance();
        Task<List<Employee>> GetAllEmployee();
        Task<Employee> GetEmployeeByPin(string pin);
    }
}
