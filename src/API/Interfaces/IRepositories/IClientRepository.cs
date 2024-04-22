using API.Dapper.Entities;

namespace API.Dapper.Interfaces.IRepositories
{
    public interface IClientRepository
    {
        int Insert(Client client);
        void Update(Client client);
        void Delete(Client client);
        Client GetById(int id);
        Client GetByName(string Name);
    }
}
