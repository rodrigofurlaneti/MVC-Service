using System.Collections.Generic;
namespace MeuHelp.Models
{
    public class Typeservice
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Typeservice()
        {
        }
        public Typeservice(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
