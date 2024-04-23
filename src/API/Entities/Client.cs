using Dapper.Contrib.Extensions;


namespace API.DemoDapper.Entities
{
    public enum DocumentType
    { 
        CPF = 1,
        Identidade = 2,
        Passaport = 3
    }
    [Table("Client")]
    public class Client
    {
        public Client()
        {
            
        }
        public Client(string name, DocumentObjectValue document)
        {
            Name = name;
            //Document = document;

        }
        public int Id { get; set; }  
        public string Name { get; set; }
        

        //public AddressObjectValue Address { get; set; }
        //public DocumentObjectValue Document { get; set; }



    }

    public class DocumentObjectValue
    {
        public string Document{ get; set; }
        public DocumentType Type { get; set; }

        public DateTime DateIssue { get; set; }
    }


    public class AddressObjectValue
    {
        public int Id { get; set; }

        public int ClientId { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string Complementary { get; set; }
        public bool IsDeleted { get; set; }
    }
}
