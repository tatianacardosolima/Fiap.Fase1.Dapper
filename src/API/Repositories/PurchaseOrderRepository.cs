using API.DemoDapper.Entities;
using API.DemoDapper.Interfaces.IRepositories;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Data;

namespace API.DemoDapper.Repositories
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
            return (int)_connection.Insert<PurchaseOrder>(purchaseOrder);
        }

        public void Update(PurchaseOrder purchaseOrder)
        {
            _connection.Update<PurchaseOrder>(purchaseOrder);
        }
    }
}
