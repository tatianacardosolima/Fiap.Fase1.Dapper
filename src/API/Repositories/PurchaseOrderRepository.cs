using API.Dapper.Entities;
using API.Dapper.Interfaces.IRepositories;
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
            throw new NotImplementedException();
        }

        public PurchaseOrder GetById(int id)
        {
            throw new NotImplementedException();
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
