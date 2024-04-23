using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.DemoDapper.Controllers
{
    [ApiController]
    [Route("api/purchase-orders")]

    public class PurchaseOrderController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get(int page=1, int size=10)
        {
            List<dynamic> clients = new List<dynamic>();
            clients.Add(new { nome = "Joao", cpf = "123456458911" });
            clients.Add(new { nome = "Maria", cpf = "98765432125" });
            return Ok(clients);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            List<dynamic> clients = new List<dynamic>();
            clients.Add(new { nome = "Joao", cpf = "123456458911" });
            clients.Add(new { nome = "Maria", cpf = "98765432125" });
            return Ok(clients);
        }
        [HttpPost]        
        public IActionResult Post()
        {
            List<dynamic> clients = new List<dynamic>();
            clients.Add(new { nome = "Joao", cpf = "123456458911" });
            clients.Add(new { nome = "Maria", cpf = "98765432125" });
            return Ok(clients);
        }

        [HttpPut]        
        public IActionResult Put()
        {
            List<dynamic> clients = new List<dynamic>();
            clients.Add(new { nome = "Joao", cpf = "123456458911" });
            clients.Add(new { nome = "Maria", cpf = "98765432125" });
            return Ok(clients);
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            List<dynamic> clients = new List<dynamic>();
            clients.Add(new { nome = "Joao", cpf = "123456458911" });
            clients.Add(new { nome = "Maria", cpf = "98765432125" });
            return Ok(clients);
        }

    }
}
