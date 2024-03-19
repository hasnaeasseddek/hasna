﻿using Freelance.Core.Features.Experiences.Queries.Results;
using Freelance.Core.Features.Formations.Queries.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Core.Features.Experiences.Queries.Models
{
    public class GetExperienceByIDQuery : IRequest<GetSingleExperienceResponse>
    {
        public int IdExperience { get; set; }
        public GetExperienceByIDQuery(int id)
        {
            IdExperience = id;
        }
    }
}
