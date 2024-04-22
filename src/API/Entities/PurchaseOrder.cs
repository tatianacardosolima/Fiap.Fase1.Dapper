namespace API.Dapper.Entities
{

    public enum PurchaseOrderStatus
    {
        Registered = 0,
        AwaitingPayment = 1,
        PaidOut = 2,
    }
    public class PurchaseOrder
    {
        public PurchaseOrder()
        {        
        }
        public string Id { get; set; }  
        public Client Client{ get; set; }    
        public DateTime DateIssue { get; set; }
        public PurchaseOrderStatus Status { get; set; }

    }
}
