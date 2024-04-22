using API.Dapper.Entities;

namespace API.Dapper.Interfaces.IRepositories
{
    public interface IPurchaseOrderItemRepository
    {
        int Insert(PurchaseOrderItem purchaseOrderItem);
        void Update(PurchaseOrderItem purchaseOrderItem);
        void Delete(PurchaseOrderItem purchaseOrderItem);
        PurchaseOrderItem GetById(int id);        
    }
}
