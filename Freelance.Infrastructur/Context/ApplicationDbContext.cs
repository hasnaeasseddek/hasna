using Freelance.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.InfrastructurData
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Entreprise> Entreprises { get; set; }
        public DbSet<Offre> Offres { get; set; }
        public DbSet<Candidat> Candidat { get; set; }
        public DbSet<Formation> Formations { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Projet> Projets { get; set; }
    }
}
