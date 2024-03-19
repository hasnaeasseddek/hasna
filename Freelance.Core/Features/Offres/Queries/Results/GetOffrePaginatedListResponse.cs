using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Offres.Queries.Results
{
    public class GetOffrePaginatedListResponse
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

        public GetOffrePaginatedListResponse(int id, string? titre, string? descrpition, DateTime? date, string? dure, string? adresse, string? ville, DateTime? datePub, int? idEntreprise, string? entrepriseName)
        {
            Id = id;
            Titre = titre;
            Descrpition = descrpition;
            Date = date;
            Dure = dure;
            Adresse = adresse;
            Ville = ville;
            DatePub = datePub;
            IdEntreprise = idEntreprise;
            EntrepriseName = entrepriseName;

        }
    }
}
