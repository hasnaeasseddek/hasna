using Freelance.Application.Services.Condidate.CandidatService;
using Freelance.Application.ViewModels.DTOs.CondidatCompDTO;
using Freelance.Application.ViewModels.DTOs.CondidateDTO;
using Freelance.Application.ViewModels.DTOs.ExperienceDTO;
using Freelance.Application.ViewModels.DTOs.FormationDTO;
using Freelance.Application.ViewModels.DTOs.ProjetDTO;
using Freelance.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Freelance.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CandidatController : ControllerBase
{
    private readonly ICandidateService _condidateService;
    public CandidatController(ICandidateService condidateService)
    {
        _condidateService = condidateService;
    }


    //[HttpGet("{id}")]
    //public async Task<IActionResult> GetById(int id)
    //{
    //    var condidatDTO = await _condidateService.FindByIdAsync(id);

    //    if (condidatDTO == null)
    //    {
    //        return NotFound();
    //    }

    //    return Ok(condidatDTO);
    //}

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var candidat = await _condidateService.GetCandidatWithDetailsAsync(id);

        if (candidat == null)
            return NotFound();

        var candidatDto = new CandidatDTO
        {
            Id = candidat.Id,
            FirstName = candidat.FirstName,
            LastName = candidat.LastName,
            Email = candidat.Email,
            Titre = candidat.Titre,
            Gender = candidat.Gender,
            Avatar = candidat.Avatar,
            Adresse = candidat.Adresse,
            DateNaissance = candidat.DateNaissance,
            Tele = candidat.Tele,
            Mobilite = candidat.Mobilite,
            Disponibilite = candidat.Disponibilite,
            Ville = candidat.Ville,

            CondidatComps = candidat.CondidatComps.Select(c => new CondidatCompGetDTO
            {
                Id = c.Id,
                Niveau = c.Niveau,
                IdComp = c.IdComp,
                IdCond = c.IdCond,
            }).ToList(),

            Experiences = candidat.Experiences.Select(exp => new ExperienceGetDTO
            {
                Id = exp.Id,
                Titre = exp.Titre,
                Local = exp.Local,
                Description = exp.Description,
                Ville = exp.Ville,
                DateDebut = exp.DateDebut,
                DateFin = exp.DateFin,

            }).ToList(),

            Formations = candidat.Formations.Select(form => new FormationGetDTO
            {
                Id = form.Id,
                Niveau = form.Niveau,
                Ecole = form.Ecole,
                Diplome = form.Diplome,
                Description = form.Description,
                Ville = form.Ville,
                DateDebut = form.DateDebut,
                DateFin = form.DateFin,
            }).ToList(),

            Projets = candidat.Projets.Select(p => new ProjetGetDTO
            {
                Id = p.Id,
                Nom = p.Nom,
                Description = p.Description,
                Link = p.Link,

            }).ToList(),
        };

        return Ok(candidatDto);
    }

    [HttpGet]
    public async Task<ActionResult<List<CandidatDTO>>> GetAll()
    {
        var candidats = await _condidateService.GetAllCandidatsWithDetailsAsync();

        var candidatDtos = candidats.Select(candidat => new CandidatDTO
        {
            Id = candidat.Id,
            FirstName = candidat.FirstName,
            LastName = candidat.LastName,
            Email = candidat.Email,
            Titre = candidat.Titre,
            Gender = candidat.Gender,
            Avatar = candidat.Avatar,
            Adresse = candidat.Adresse,
            DateNaissance = candidat.DateNaissance,
            Tele = candidat.Tele,
            Mobilite = candidat.Mobilite,
            Disponibilite = candidat.Disponibilite,
            Ville = candidat.Ville,

            CondidatComps = candidat.CondidatComps.Select(cc => new CondidatCompGetDTO
            {
                Id = cc.Id,
                Niveau = cc.Niveau,
                IdComp = cc.IdComp,
                IdCond = cc.IdCond,
            }).ToList(),

            Experiences = candidat.Experiences.Select(exp => new ExperienceGetDTO
            {
                Id = exp.Id,
                Titre = exp.Titre,
                Local = exp.Local,
                Description = exp.Description,
                Ville = exp.Ville,
                DateDebut = exp.DateDebut,
                DateFin = exp.DateFin,
            }).ToList(),

            Formations = candidat.Formations.Select(form => new FormationGetDTO
            {
                Id = form.Id,
                Niveau = form.Niveau,
                Ecole = form.Ecole,
                Diplome = form.Diplome,
                Description = form.Description,
                Ville = form.Ville,
                DateDebut = form.DateDebut,
                DateFin = form.DateFin,
            }).ToList(),

            Projets = candidat.Projets.Select(p => new ProjetGetDTO
            {
                Id = p.Id,
                Nom = p.Nom,
                Description = p.Description,
                Link = p.Link,
            }).ToList(),
        }).ToList();

        return Ok(candidatDtos);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CandidatCreateDTO addPartnerDto)
    {
        var createCondidatDTO = await _condidateService.CreateAsync(addPartnerDto);
        return CreatedAtAction(nameof(GetById), new { id = createCondidatDTO.Id }, createCondidatDTO);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] CandidatUpdateDTO updatePartnerDto)
    {
        var updateCondidatDTO = await _condidateService.UpdateAsync(id, updatePartnerDto);

        if (updateCondidatDTO == null)
        {
            return NotFound();
        }

        return Ok(updateCondidatDTO);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _condidateService.DeleteAsync(id);
        return NoContent();
    }
}