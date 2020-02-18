using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuHelp.Models.ViewModels
{
    public class CollaboratorFormViewModel
    {
        public Collaborator Collaborator { get; set; }
        public ICollection<Legalperson> Legalpersons { get; set; }
        public ICollection<Shippingway> Shippingways { get; set; }
        public ICollection<Plan> Plans { get; set; }
        public ICollection<Saleschannel> Saleschannels { get; set; }
    }
}
