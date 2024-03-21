using Freelance.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Entreprises.Queries.Results
{
    public class GetEntrepriseListResponse
    {
        public int Id { get; set; }
        public string IdUserReference { get; set; }
        public string? Name { get; set; }
        public string? RaisonSociale { get; set; }

        public byte[]? Logo { get; set; }

        public DateTime? DateCreation { get; set; }

        public string? Adresse { get; set; }

        public string? Ville { get; set; }


        public List<OffreEntRess>? OffreList { get; set; }
    }
    public class OffreEntRess
    {
        public int Id { get; set; }
        public string? Titre { get; set; }
        public string? Descrpition { get; set; }
        public DateTime? Date { get; set; }
        public string? Dure { get; set; }
        public string? Adresse { get; set; }
        public string? Ville { get; set; }
        public DateTime? DatePub { get; set; }
    }
}
