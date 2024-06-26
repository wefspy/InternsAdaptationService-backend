﻿using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels.User;

namespace InternsAdaptationService.Infrastructure.DTO.RequestModels.User;

public class UserRequestModel : IUserRequestModel
{
    public string Name { get; }

    public string Surname { get; }

    public string? MiddleName { get; }

    public string? Url { get; }

    public string? DesciptionProfile { get; }

    public string? Telegram { get; }

    public string? VK { get; }

    public UserRequestModel(string name, string surname, string? middleName, string? url, string? desciptionProfile, string? telegram, string? vk)
    {
        Name = name;
        Surname = surname;
        MiddleName = middleName;
        Url = url;
        DesciptionProfile = desciptionProfile;
        Telegram = telegram;
        VK = vk;
    }
}
