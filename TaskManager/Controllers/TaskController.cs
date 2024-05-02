using Microsoft.AspNetCore.Mvc;
using TaskManager.DataAccess.Infrastructure;
using TaskManager.Helper;
using TaskManager.Services;

namespace TaskManager.Controllers;

[ApiController]
[Route("api/[controller]")]
//ToDo: Agregar User model para usar Authorize

public class TaskController : ControllerBase
{
    private readonly IUnitOfWork _unitOfWork;

    public TaskController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    [HttpGet]
    public async Task<IActionResult> ListAll()
    {
        var tasks = await _unitOfWork.TaskRepository.GetAllActive();
        int pageToShow = 1;

        if (Request.Query.ContainsKey("page"))
        {
            int.TryParse(Request.Query["page"], out pageToShow);
        }
        
        var url = new Uri($"{Request.Scheme}://{Request.Host}{Request.Path}").ToString();
        var paginateTasks = PaginateHelper.Paginate(tasks, pageToShow, url);
            
        return ResponseFactory.CreateSuccessResponse(200, paginateTasks);

        //ToDo: Ver como funciona el paginado, probar si funciona el listAll, y generar la base de datos desde el Code-First
        //ToDo: Ver como funciona el Program.cs
    }
    
}