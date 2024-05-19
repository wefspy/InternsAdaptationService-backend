﻿using InternsAdaptationService.Data.Entities.Internships;
using InternsAdaptationService.Infrastructure.DTO.RequestModels.Internships;
using InternsAdaptationService.Infrastructure.DTO.ResponseModels.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IMappers.IDTOMappers.Internships;
using InternsAdaptationService.Infrastructure.Interfaces.IServices.Internships;
using InternsAdaptationService.Infrastructure.Managers.Abstracts;

namespace InternsAdaptationService.Infrastructure.Managers.Internships;

public class MentorInternManager : BaseManager<MentorInternEntity, MentorInternRequestModel, MentorInternResponseModel>,
    IMentorInternManager
{
    private readonly IMentorInternService _mentorInternService;
    private readonly IMentorInternMapper _mentorInternMapper;

    public MentorInternManager(IMentorInternService mentorInternService, IMentorInternMapper mentorInternMapper) : 
        base(mentorInternService, mentorInternMapper)
    {
        _mentorInternService = mentorInternService;
        _mentorInternMapper = mentorInternMapper;
    }

    public async Task<IEnumerable<MentorInternResponseModel>> GetByMentorIdAsync(Guid id)
    {
        var entities = await _mentorInternService.GetByMentorIdAsync(id);

        return entities
            .Select(entity => _mentorInternMapper.ToResponse(entity));
    }

    public async Task<IEnumerable<MentorInternResponseModel>> GetByInternIdAsync(Guid id)
    {
        var entities = await _mentorInternService.GetByInternIdAsync(id);

        return entities
            .Select(entity => _mentorInternMapper.ToResponse(entity));
    }
}