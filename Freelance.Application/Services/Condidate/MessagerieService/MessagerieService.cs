using AutoMapper;
using Freelance.Application.Persistence.IRepositories;
using Freelance.Application.ViewModels.DTOs.MessagerieDTO;
using Freelance.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.MessagerieService;

public class MessagerieService : IMessagerieService
{

    readonly IGenericRepository<Messagerie> _messagrieService;
    private readonly IMapper _mapper;

    public MessagerieService(IGenericRepository<Messagerie> messagerieSerice, IMapper mapper)
    {
        _mapper = mapper;
        _messagrieService = messagerieSerice;
    }

    public Task<MessagerieDTO> CreateAsync(MessagerieCreateDTO entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<MessagerieDTO>> FindAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<MessagerieDTO> FindByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<MessagerieDTO> UpdateAsync(int id, MessagerieUpdateDTO entity)
    {
        throw new NotImplementedException();
    }
}
