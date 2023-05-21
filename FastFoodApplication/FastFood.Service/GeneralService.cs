using FastFood.Models;
using FastFood.Service.Interfaces;
using Microsoft.Data.SqlClient;
using System.Linq.Expressions;

namespace FastFood.Service
{
    public class GeneralService : IGeneralRepository
    {
        public async Task<List<General>> GetBalanceAsync()
        {
            const string sqlExpression = "sp_getWholeBalance";
            List<General> result = new();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    await connection.OpenAsync();
                    SqlDataReader reader =  await command.ExecuteReaderAsync();
                    if(reader.HasRows)
                    {
                        while(await reader.ReadAsync())
                        {
                            result.Add(reader[0]);
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
            }
        }
    }
}
