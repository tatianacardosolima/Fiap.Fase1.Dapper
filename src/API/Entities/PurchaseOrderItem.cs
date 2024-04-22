namespace API.Dapper.Entities
{    
    
    public class PurchaseOrderItem
    {
        public PurchaseOrderItem()
        {        
        }
        public string Id { get; set; }  
        public string Name { get; set; }    
        public string Password { get; set; }
        public ProductValueObject Product { get; set; }

        public int Amount { get; set; }
        public int Price { get; set; }
        public int Tax { get; set; }
        public int Discount { get; set; }

    }

    public class ProductValueObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Description { get; set; }
        public double CurrentPrice { get; set; }
        public double MaximumDiscountAllowed { get; set; }

    }
}
