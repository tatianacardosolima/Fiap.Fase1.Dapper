using API.DemoDapper.Entities;

namespace API.DemoDapper.Interfaces.IRepositories
{
    public interface IPurchaseOrderItemRepository
    {
        int Insert(PurchaseOrderItem purchaseOrderItem);
        void Update(PurchaseOrderItem purchaseOrderItem);
        void Delete(PurchaseOrderItem purchaseOrderItem);
        PurchaseOrderItem GetById(int id);        
    }
}
