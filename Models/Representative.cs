using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeuHelp.Models
{
    public class Representative
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Faltou registrar o nome do vendedor!")]
        [Display(Name = "Nome do vendedor:", Prompt = "Entre com o nome do vendedor!", Description = "Nome do vendedor")]
        [Column(TypeName = "VARCHAR(50)")]
        [StringLength(50)]
        public string Name { get; set; }
        public Representative()
        {
                
        }
        public Representative(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
