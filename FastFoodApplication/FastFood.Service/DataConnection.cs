using FastFood.Models;
using FastFood.Service;
using FastFood.Service.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Linq.Expressions;
using System.Net.NetworkInformation;

namespace FastFood.Service
{
    public class DataConnection : IDataConnection
    {
        public async Task<Employee> AddNewEmployee(Employee model)
        {
            const string sqlExpression = "sp_addNewEmployee";
            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("employeePin", model.Pin);

                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }
            }

            return model;
        }

        public async Task<List<Employee>> GetAllEmployee()
        {
            List<Employee> result = new();
            const string sqlExpression = "sp_getAllEmployee";

            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    await connection.OpenAsync();

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            result.Add(new Employee
                            {
                                Id = reader.GetInt32(0),
                                Pin = reader.GetString(1)
                            });
                        }
                    }
                }
                catch (SqlException)
                {

                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }
            }
            return result;
        }

        public async Task<General> GetBalance()
        {
            const string sqlExpression = "sp_getWholeBalance";
            General result = new();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    await connection.OpenAsync();
                    SqlDataReader reader =  await command.ExecuteReaderAsync();
                    if(reader.HasRows)
                    {
                        while(await reader.ReadAsync())
                        {
                            result.Balance = reader.GetDouble(0);
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }

                return result;
            }
        }

        public async Task<Employee> GetEmployeeByPin(string pin)
        {
            Employee result = new();
            const string sqlExpression = "sp_getEmployeeByPin";

            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression,connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("employeePin", pin);

                    await connection.OpenAsync();
                    SqlDataReader reader =  await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            result.Id = reader.GetInt32(0);
                            result.Pin = reader.GetString(1);
                        }
                    }
                }
                catch (SqlException)
                {

                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }
            }
            return result;
        }
        public async Task<List<Product>> GetAllProducts()
        {
            List<Product> result = new();
            const string sqlExpression = "sp_getAllProducts";

            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    await connection.OpenAsync();

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            result.Add(new Product
                            {
                                Id = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                Price = reader.GetDouble(2),
                                Quantity = reader.GetInt32(3)
                            });
                        }
                    }
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }
            }
            return result;
        }
        public async Task<Product> GetProductByTitle(string title)
        {
            Product result = new();
            const string sqlExpression = "sp_getProductByTitle";

            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("title", title);

                    await connection.OpenAsync();
                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
                        {
                            result.Id = reader.GetInt32(0);
                            result.Title = reader.GetString(1);
                        }
                    }
                }
                catch (SqlException)
                {

                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }
            }
            return result;
        }
        public async Task<Product> AddNewProduct(Product model)
        {
            const string sqlExpression = "sp_addNewProduct";
            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@title", model.Title);
                    command.Parameters.AddWithValue("@price", model.Price);
                    command.Parameters.AddWithValue("@quantity", model.Quantity);

                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }
            }
            return model;
        }
    }
}