using Bogus;
using RegisterAndLoginApp.Models;

namespace RegisterAndLoginApp.Services
{
    public class HardCodedSampleRepo : IClientDataService
    {
        static List<ClientModel> clientsList = new List<ClientModel>();
        public string Delete(ClientModel client)
        {
            throw new NotImplementedException();
        }

        public List<ClientModel> GetAllClients()
        {
            if (clientsList.Count == 0)
            {
                clientsList.Add(new ClientModel { ClientName = "Timmy", ClientAge = 8, ClientInsurance = "Medicare", ClientAllowedHours = 30, ClientBcba = "Morgan", MainContact = "Mom", MainContactNumber = "469-412-4904" });
                clientsList.Add(new ClientModel { ClientName = "Marco", ClientAge = 19, ClientInsurance = "Medicare", ClientAllowedHours = 50, ClientBcba = "Morgan", MainContact = "Dad", MainContactNumber = "469-412-4904" });

                for (int i = 0; i < 50; i++)
                {
                    clientsList.Add(new Faker<ClientModel>()
                        .RuleFor(p => p.ClientName, f => f.Name.FullName())
                        .RuleFor(p => p.ClientAge, f => f.Random.Int(5, 21))
                        .RuleFor(p => p.ClientInsurance, f => f.Company.CompanyName())
                        .RuleFor(p => p.ClientAllowedHours, f => f.Random.Int(1, 50))
                        .RuleFor(p => p.ClientBcba, f => f.Name.FullName())
                        .RuleFor(p => p.MainContact, f => f.Name.FullName())
                        .RuleFor(p => p.MainContactNumber, f => f.Phone.PhoneNumber()));
                }
            }
            
            return clientsList;
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
