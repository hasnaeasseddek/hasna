using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Offres.Queries.Results
{
    public class GetOffreListResponse
    {
        public int Id { get; set; }
        public string? Titre { get; set; }
        public string? Descrpition { get; set; }
        public DateTime? Date { get; set; }
        public string? Dure { get; set; }
        public string? Adresse { get; set; }
        public string? Ville { get; set; }
        public DateTime? DatePub { get; set; }
        public int? IdEntreprise { get; set; }
        public string? EntrepriseName { get; set; }
    }
}
