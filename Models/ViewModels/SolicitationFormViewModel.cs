using System.Collections.Generic;

namespace MeuHelp.Models.ViewModels
{
    public class SolicitationFormViewModel
    {
        public Solicitation Solicitation { get; set; }
        public ICollection<Typeservice> TypeServices { get; set; }
    }
}
