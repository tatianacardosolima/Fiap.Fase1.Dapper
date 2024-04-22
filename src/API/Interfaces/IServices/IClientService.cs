using API.Dapper.Entities;

namespace API.Dapper.Interfaces.IServices
{
    public interface IClientService
    {
        void AddNewClient(Client client);

        void UpdateClient(Client client);

        void Delete(int id);
        
        Client GetById(int id);
    }
}
