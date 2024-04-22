using API.Dapper.Entities;
using API.Dapper.Interfaces.IRepositories;
using API.Dapper.Interfaces.IServices;

namespace API.Dapper.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public void AddNewClient(Client client)
        {
            client.Id =  _clientRepository.Insert(client);            
        }

        public void Delete(int id)
        {
            var client = GetById(id);
            if (client != null)
                _clientRepository.Delete(client);
            else
                throw new Exception("Id not found!");
        }

        public Client GetById(int id)
        {
            return _clientRepository.GetById(id);
        }

        public void UpdateClient(Client client)
        {
            _clientRepository.Update(client);
        }
    }
}
