using RegisterAndLoginApp.Models;

namespace RegisterAndLoginApp.Services
{
    public interface IClientDataService
    {
        List<ClientModel> GetAllClients();
        List<ClientModel> SearchClients(string searchTerm);
        ClientModel GetClientByName(string name);
        string Insert(ClientModel client);
        string Delete(ClientModel client);
        string Update(ClientModel client); 
    }
}
