using System.Collections.Generic;
namespace MeuHelp.Models.ViewModels
{
    public class LegalpersonFormViewModel
    {
        public Legalperson Legalperson { get; set; }
        public ICollection<Typeservice> Typeservices { get; set; }
    }
}
