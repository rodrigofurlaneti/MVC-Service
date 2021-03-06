﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuHelp.Models
{
    public class Saleschannel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Physicalperson> Physicalpersons { get; set; } = new List<Physicalperson>();
        public Saleschannel()
        {
        }
        public Saleschannel(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
