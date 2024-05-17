using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Parents;
using InternsAdaptationService.Infrastructure.Interfaces.IRequestModels;
using InternsAdaptationService.Infrastructure.Interfaces.IResponseModels.Parents;
using Microsoft.AspNetCore.Mvc;

namespace InternsAdaptationService.API.Controllers.Children.Abstracts;

public abstract class BaseController<TRequest, TResponse, TManager> : ControllerBase
    where TRequest : IBaseRequestModel
    where TResponse : IBaseResponseModel
    where TManager : IBaseManager<TRequest, TResponse>
{
    private readonly TManager _manager;

    protected BaseController(TManager manager)
    {
        _manager = manager;
    }

    [HttpPost]
    public virtual async Task<ActionResult<TResponse>> Create(TRequest request)
    {
        try
        {
            var result = await _manager.CreateAsync(request);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("{id:Guid}")]
    public virtual async Task<IActionResult> Update(Guid id, TRequest request)
    {
        try
        {
            await _manager.UpdateAsync(id, request);

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    public virtual async Task<ActionResult<IEnumerable<TResponse>>> GetAll()
    {
        try
        {
            var result = await _manager.GetAllAsync();

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id:Guid}")]
    public virtual async Task<ActionResult<TResponse>> GetById(Guid id)
    {
        try
        {
            var result = await _manager.GetByIdAsync(id);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id:Guid}")]
    public virtual async Task<IActionResult> Delete(Guid id)
    {
        try
        {
            await _manager.DeleteAsync(id);

            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
