using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bucnari_Mihaela_Lab2.Models;

namespace Bucnari_Mihaela_Lab2.Data
{
    public class Bucnari_Mihaela_Lab2Context : DbContext
    {

        public Bucnari_Mihaela_Lab2Context (DbContextOptions<Bucnari_Mihaela_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Bucnari_Mihaela_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Bucnari_Mihaela_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Bucnari_Mihaela_Lab2.Models.Author> Authors { get; set; }
    }
}
