using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Experiences.Queries.Results
{
    public class GetExperienceListResponse
    {
        public int Id { get; set; }

        public string? Titre { get; set; }

        public string? Local { get; set; }

        public string? Description { get; set; }

        public string? Ville { get; set; }

        public DateTime? DateDebut { get; set; }

        public DateTime? DateFin { get; set; }

        public int? IdCondidat { get; set; }
    }
}
