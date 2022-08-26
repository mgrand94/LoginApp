using RegisterAndLoginApp.Models;
using System.Data.SqlClient;

namespace RegisterAndLoginApp.Services
{
    public class ClientsDAO : IClientDataService
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public string Delete(ClientModel client)
        {
            throw new NotImplementedException();
        }

        public List<ClientModel> GetAllClients()
        {
            List<ClientModel> foundClients = new List<ClientModel>();
            //get all clients from DB
            string sqlStatement = "SELECT * FROM dbo.Clients";
            //using connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        foundClients.Add(new ClientModel { 
                            ClientName = (string)reader[1], 
                            ClientAge = (int)reader[2], 
                            ClientInsurance = (string)reader[3], 
                            ClientAllowedHours = (decimal)reader[4],
                            ClientBcba = (string)reader[5],
                            MainContact = (string)reader[6],
                            MainContactNumber = (string)reader[7] 
                        });
                    }

                }catch (Exception ex)   
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return foundClients;
        }

        public ClientModel GetClientByName(string name)
        {
            throw new NotImplementedException();
        }

        public string Insert(ClientModel client)
        {
            throw new NotImplementedException();
        }

        public List<ClientModel> SearchClients(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public string Update(ClientModel client)
        {
            throw new NotImplementedException();
        }
    }
}
