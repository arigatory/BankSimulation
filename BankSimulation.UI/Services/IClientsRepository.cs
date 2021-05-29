using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSimulation.Model;

namespace BankSimulation.UI.Services
{
    public interface IClientsRepository
    {
        Task<List<Client>> GetClientsAsync();
        Task<Client> GetClientAsync(string name);
        Task<Client> UpdateClient(string name);
        Task DleteCustomerAsync(string name);
    }
}
