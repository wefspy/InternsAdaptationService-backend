﻿using InternsAdaptationService.Data.Interfaces.IEntities.Parents;

namespace InternsAdaptationService.Data.Entities.Parents;

public abstract class BaseEntity : IBaseEntity
{
    public Guid Id { get; set; }
}
