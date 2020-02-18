using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuHelp.Models
{
    public class ApiCpf
    {
        public string Number { get; set; }
        public string Name { get; set; }

        public ApiCpf(string number, string name)
        {
            Number = number;
            Name = name;
        }

        public ApiCpf()
        {
        }
    }
}
