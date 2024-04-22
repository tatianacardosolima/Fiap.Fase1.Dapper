using API.Dapper.Entities;

namespace API.Dapper.Interfaces.IRepositories
{
    public interface IPurchaseOrderRepository
    {
        int Insert(PurchaseOrder purchaseOrder);
        void Update(PurchaseOrder purchaseOrder);
        void Delete(PurchaseOrder purchaseOrder);
        PurchaseOrder GetById(int id);

    }
}
