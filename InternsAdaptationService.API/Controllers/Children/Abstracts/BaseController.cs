using InternsAdaptationService.Infrastructure.Interfaces.IManagers.Abstracts;
using InternsAdaptationService.Infrastructure.Interfaces.IRequestModels;
using InternsAdaptationService.Infrastructure.Interfaces.IResponseModels;
using Microsoft.AspNetCore.Mvc;

namespace InternsAdaptationService.API.Controllers.Children.Abstracts;

public abstract class BaseController<TRequestModel, TResponseModel, TManager> : ControllerBase
    where TRequestModel : IBaseRequestModel
    where TResponseModel : IBaseResponseModel
    where TManager : IBaseManager<TRequestModel, TResponseModel>
{
    private readonly TManager _manager;

    protected BaseController(TManager manager)
    {
        _manager = manager;
    }

    [HttpPost]
    public virtual async Task<ActionResult<TResponseModel>> Create(TRequestModel request)
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
    public virtual async Task<IActionResult> Update(Guid id, TRequestModel request)
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
    public virtual async Task<ActionResult<IEnumerable<TResponseModel>>> GetAll()
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
    public virtual async Task<ActionResult<TResponseModel>> GetById(Guid id)
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
