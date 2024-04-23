using API.DemoDapper.Entities;
using API.DemoDapper.Interfaces.IRepositories;
using Dapper.Contrib.Extensions;
using System.Data;

namespace API.DemoDapper.Repositories
{
    public class PurchaseOrderItemRepository : IPurchaseOrderItemRepository
    {
        private readonly IDbConnection _connection;

        public PurchaseOrderItemRepository(IDbConnection connection)
        {
            _connection = connection;

        }

        public void Delete(PurchaseOrderItem purchaseOrderItem)
        {
            _connection.Delete<PurchaseOrderItem>(purchaseOrderItem);
        }

        public PurchaseOrderItem GetById(int id)
        {
            return _connection.Get<PurchaseOrderItem>(id);

        }

        public int Insert(PurchaseOrderItem purchaseOrderItem)
        {
            return (int)_connection.Insert<PurchaseOrderItem>(purchaseOrderItem);
        }

        public void Update(PurchaseOrderItem purchaseOrderItem)
        {
            _connection.Update<PurchaseOrderItem>(purchaseOrderItem);
        }
    }
}
