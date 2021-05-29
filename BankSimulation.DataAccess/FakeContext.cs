using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSimulation.Model;
using Bogus;
using Bogus.DataSets;
using Microsoft.VisualBasic;

namespace BankSimulation.DataAccess
{
    public class FakeContext
    {
        public IEnumerable<Client> Clients;

        public FakeContext()
        {
            var testUsers = new Faker<BankSimulation.Model.Person>("ru")
                //Optional: Call for objects that have complex initialization

                //Basic rules using built-in generators
                .RuleFor(p => p.Gender, f => f.PickRandom<Gender>())
                .RuleFor(p => p.Name, (f, p) => f.Name.FullName((Name.Gender?)p.Gender));

            Clients = testUsers.Generate(10);
        }
    }
}
