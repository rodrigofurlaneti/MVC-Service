using System.Collections.Generic;

namespace MeuHelp.Models
{
    public class Plan
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }
        public ICollection<Physicalperson> Physicalpersons { get; set; } = new List<Physicalperson>();
        public Plan()
        {
        }

        public Plan(int id, string nome, string valor)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
        }
    }
}
