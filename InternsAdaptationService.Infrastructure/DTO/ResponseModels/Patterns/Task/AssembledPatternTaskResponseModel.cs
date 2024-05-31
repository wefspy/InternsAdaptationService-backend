﻿using InternsAdaptationService.Infrastructure.DTO.RequestModels.Patterns.Task;
using InternsAdaptationService.Infrastructure.Interfaces.IResponseModels;

namespace InternsAdaptationService.Infrastructure.DTO.ResponseModels.Patterns.Task;

public class AssembledPatternTaskResponseModel : AssembledPatternTaskRequestModel, IBaseResponseModel
{
    public Guid Id { get; }

    public AssembledPatternTaskResponseModel(Guid id, Guid mentorId, Guid planId, string title, string description,
        int startDate, int endDate, bool reusable)
        : base(id, mentorId, planId, title, description, startDate, endDate, reusable)
    {
        Id = id;
    }
}
