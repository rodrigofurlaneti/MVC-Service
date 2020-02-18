using System.Collections.Generic;
namespace MeuHelp.Models.ViewModels
{
    public class ServiceproviderFormViewModel
    {
        public Serviceprovider Serviceprovider { get; set; }
        public ICollection<Typeservice> Typeservices { get; set; }
    }
}
