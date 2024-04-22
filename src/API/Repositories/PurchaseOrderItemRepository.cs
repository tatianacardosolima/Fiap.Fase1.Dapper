using API.Dapper.Entities;
using API.Dapper.Interfaces.IRepositories;
using System.Data;
using System.Data.Common;

namespace API.Dapper.Repositories
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
            throw new NotImplementedException();
        }

        public PurchaseOrderItem GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(PurchaseOrderItem purchaseOrderItem)
        {
            throw new NotImplementedException();
        }

        public void Update(PurchaseOrderItem purchaseOrderItem)
        {
            throw new NotImplementedException();
        }
    }
}
