using API.Dapper.Entities;
using API.Dapper.Interfaces.IRepositories;
using System.Data;
using System.Data.Common;

namespace API.Dapper.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly IDbConnection _connection;

        public ClientRepository(IDbConnection connection)
        {
            _connection = connection;

        }
        public void Delete(Client client)
        {
            throw new NotImplementedException();
        }

        public Client GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Client GetByName(string Name)
        {
            throw new NotImplementedException();
        }

        public int Insert(Client client)
        {
            throw new NotImplementedException();
        }

        public void Update(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
