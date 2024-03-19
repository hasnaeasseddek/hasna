using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Projets.Queries.Result
{
    public class GetSingleProjetResponse
    {
        public int Id { get; set; }
        public string? Nom { get; set; }
        public string? Description { get; set; }
        public string? Link { get; set; }

        public int? IdCondidat { get; set; }
    }
}
