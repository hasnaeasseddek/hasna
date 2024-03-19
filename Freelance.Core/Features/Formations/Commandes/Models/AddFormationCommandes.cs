﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Formations.Commandes.Models
{
    public class AddFormationCommandes : IRequest<string>
    {
        public string? Niveau { get; set; }
        public string? Ecole { get; set; }
        public string? Diplome { get; set; }
        public string? Description { get; set; }
        public string? Ville { get; set; }
        public DateTime? DateDebut { get; set; }
        public DateTime? DateFin { get; set; }

        public int? IdCondidat { get; set; }
    }
}
