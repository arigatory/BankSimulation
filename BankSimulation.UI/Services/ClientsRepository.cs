using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSimulation.DataAccess;
using BankSimulation.Model;

namespace BankSimulation.UI.Services
{
    public class ClientsRepository : IClientsRepository
    {
        public async Task<List<Client>> GetClientsAsync()
        {
            var fk =  new FakeContext();
            return fk.Clients.ToList();
        }

        public async Task<Client> GetClientAsync(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<Client> UpdateClient(string name)
        {
            throw new NotImplementedException();
        }

        public async Task DleteCustomerAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
