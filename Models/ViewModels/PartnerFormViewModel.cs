using System.Collections.Generic;
namespace MeuHelp.Models.ViewModels
{
    public class PartnerFormViewModel
    {
        public Partner Partner { get; set; }
        public ICollection<Typeservice> Typeservice { get; set; }
    }
}
