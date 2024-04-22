using API.Dapper.Entities;
using API.Dapper.Interfaces.IRepositories;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Data;
using System.Data.Common;

namespace API.Dapper.Repositories
{
    public class PurchaseOrderRepository : IPurchaseOrderRepository
    {
        private readonly IDbConnection _connection;

        public PurchaseOrderRepository(IDbConnection connection)
        {
            _connection = connection;

        }

        public void Delete(PurchaseOrder purchaseOrder)
        {
            _connection.Delete<PurchaseOrder>(purchaseOrder);
        }

        public PurchaseOrder GetById(int id)
        {
            var commandSql = "Select * from PurchaseOrder where Id = @Id";
            return _connection.QuerySingle<PurchaseOrder>(commandSql);
        }

        public int Insert(PurchaseOrder purchaseOrder)
        {
            throw new NotImplementedException();
        }

        public void Update(PurchaseOrder purchaseOrder)
        {
            throw new NotImplementedException();
        }
    }
}
