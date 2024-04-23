using API.DemoDapper.Entities;
using API.DemoDapper.Interfaces.IRepositories;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Data;
using System.Data.SqlClient;


namespace API.DemoDapper.Repositories
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
            _connection.Delete<Client>(client);
        }

        public List<Client> Get(int page = 1, int size = 10)
        {
            var commandSql = @"Select * from Client order by Id OFFSET @page ROWS
                                FETCH NEXT @size ROWS ONLY";

            return _connection.Query<Client>(commandSql, new { page = page, size = size }).ToList();
        }

        public Client GetById(int id)
        {
            
            var commandSql = "Select * from Client where Id = @Id";
            return _connection.QueryFirst<Client>(commandSql, new { Id = id});
        }

        public Client GetByName(string name)
        {
            var commandSql = "Select * from Client where Name = @Name";
            return _connection.QuerySingle<Client>(commandSql, new { Name= name });
        }

        public int Insert(Client client)
        {
           return (int)_connection.Insert<Client>(client);
        }

        public void Update(Client client)
        {
            _connection.Update<Client>(client);
        }
    }
}
