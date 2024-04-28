using Microsoft.AspNetCore.Identity;

namespace InternsAdaptationService.Infrastructure.Interfaces.IHandlers;

public interface IErrorHandler
{
    public string IdentityExceptionsToString(IEnumerable<IdentityError> errors);
}
