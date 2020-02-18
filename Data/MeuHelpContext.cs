using Microsoft.EntityFrameworkCore;
using MeuHelp.Models;

namespace MeuHelp.Data
{
    public class MeuHelpContext : DbContext
    {
        public MeuHelpContext (DbContextOptions<MeuHelpContext> options)
            : base(options)
        {
        }
        public DbSet<MeuHelp.Models.Collaborator> Collaborator { get; set; }
        public DbSet<MeuHelp.Models.Legalperson> Legalperson { get; set; }
        public DbSet<MeuHelp.Models.Partner> Partner { get; set; }
        public DbSet<MeuHelp.Models.Physicalperson> Physicalperson { get; set; }
        public DbSet<MeuHelp.Models.Plan> Plan { get; set; }
        public DbSet<MeuHelp.Models.Saleschannel> Saleschannel { get; set; }
        public DbSet<MeuHelp.Models.Serviceprovider> Serviceprovider { get; set; }
        public DbSet<MeuHelp.Models.Shippingway> Shippingway { get; set; }
        public DbSet<MeuHelp.Models.Typeservice> Typeservice { get; set; }
        public DbSet<MeuHelp.Models.Discount> Discount { get; set; }
        public DbSet<MeuHelp.Models.Representative> Representative { get; set; }
    }
}
