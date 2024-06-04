using InternsAdaptationService.Application.Interfaces.IHandlers;
using Microsoft.AspNetCore.Identity;

namespace InternsAdaptationService.Application.Handlers;

public class ErrorHandler : IErrorHandler
{
    public string IdentityExceptionsToString(IEnumerable<IdentityError> errors)
    {
        var arrErrors = errors.Select(er => er.Code).First();
        var stringErrors = string.Join("\n", arrErrors);

        return stringErrors;
    }
}
