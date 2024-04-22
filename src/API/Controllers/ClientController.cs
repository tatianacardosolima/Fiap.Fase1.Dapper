using API.Dapper.Entities;
using API.Dapper.Interfaces.IServices;
using API.Dapper.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Dapper.Controllers
{
    [ApiController]
    [Route("api/clients")]

    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet()]
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
            var client = _clientService.GetById(id);
            if (client == null) 
            {
                return NotFound();
            }
            return Ok(client);
        }
        [HttpPost]        
        public IActionResult Post(Client client)
        {
            _clientService.AddNewClient(client);
            return Ok(client);
        }

        [HttpPut]        
        public IActionResult Put(Client client)
        {
            _clientService.UpdateClient(client);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _clientService.Delete(id);
            
            return Ok();
        }

    }
}
