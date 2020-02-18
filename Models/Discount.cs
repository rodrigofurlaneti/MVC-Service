using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeuHelp.Models
{
    public class Discount
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Faltou registrar o desconto!")]
        [Display(Name = "Desconto:", Prompt = "Entre com o desconto!", Description = "Desconto")]
        [Column(TypeName = "VARCHAR(40)")]
        [StringLength(40)]
        public string NameDiscount { get; set; }
        public Discount()
        {
        }
        public Discount(int id, string nameDiscount)
        {
            Id = id;
            NameDiscount = nameDiscount;
        }
    }
}
