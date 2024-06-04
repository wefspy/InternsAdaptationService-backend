using Microsoft.AspNetCore.Identity;

namespace InternsAdaptationService.Application.Interfaces.IHandlers;

public interface IErrorHandler
{
    public string IdentityExceptionsToString(IEnumerable<IdentityError> errors);
}
