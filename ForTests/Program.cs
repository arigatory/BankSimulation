using System;
using System.Collections.Generic;
using Bogus;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using BankSimulation.Model;
using Bogus;
using Bogus.DataSets;
using Bogus.Extensions;
using Newtonsoft.Json;
using Person = Bogus.Person;

namespace ForTests
{

    class Program
    {
        static void Main(string[] args)
        {
            var testUsers = new Faker<BankSimulation.Model.Person>("ru")
                //Optional: Call for objects that have complex initialization

                //Basic rules using built-in generators
                .RuleFor(p => p.Gender, f => f.PickRandom<Gender>())
                .RuleFor(p => p.Name, (f, p) => f.Name.FullName((Name.Gender?) p.Gender));



            var users = testUsers.Generate(100);
            Dump(users);
        }

        public static void Dump(object obj)
        {
            Console.WriteLine(DumpString(obj));
        }
        public static string DumpString(object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }
    }

 
}
