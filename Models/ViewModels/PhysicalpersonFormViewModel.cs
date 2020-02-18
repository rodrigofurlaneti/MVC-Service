using System;
using System.Collections.Generic;

namespace MeuHelp.Models.ViewModels
{
    public class PhysicalpersonFormViewModel
    {
        public Physicalperson Physicalperson { get; set; }
        public ICollection<Shippingway> Shippingways { get; set; }
        public ICollection<Plan> Plans { get; set; }
        public ICollection<Saleschannel> Saleschannels { get; set; }
    }
}
