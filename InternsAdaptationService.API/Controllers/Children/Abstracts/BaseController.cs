using InternsAdaptationService.Application.Interfaces.IManagers.Abstracts;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IRequestModels;
using InternsAdaptationService.Infrastructure.Interfaces.IDTO.IResponseModels;
using Microsoft.AspNetCore.Mvc;

namespace InternsAdaptationService.API.Controllers.Children.Abstracts;

public abstract class BaseController<TRequestModel, TIRequestModel, TResponseModel, TIResponseModel, TManager> : ControllerBase
    where TIRequestModel : IBaseRequestModel
    where TRequestModel : TIRequestModel
    where TIResponseModel : IBaseResponseModel
    where TResponseModel : TIResponseModel
    where TManager : IBaseManager<TIRequestModel, TIResponseModel>
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
