using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourProject.DTOs;

[Route("dashboard")]
[ApiController]
public class DashboardController : ControllerBase
{
    private readonly AutosDbContext _context;

    public DashboardController(AutosDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> GetDashboardData([FromBody] DashboardRequest request)
    {
        

        IQueryable<DashboardResponse> query = from m in _context.Marca
                                              join sm in _context.Submarca on m.MarcaId equals sm.MarcaId
                                              join mo in _context.Modelo on sm.SubmarcaId equals mo.SubmarcaId
                                              join d in _context.Descripcion on mo.ModeloId equals d.ModeloId
                                              select new DashboardResponse
                                              {
                                                  Marca = m.Nombre,
                                                  Submarca = sm.Nombre,
                                                  Modelo = mo.Año,
                                                  Descripcion = d.TextoDescripcion
                                              };

        if (request.FilterType == null)
        {
            var resultnull = await query.ToListAsync();
            return Ok(resultnull);
        }
           

        {
            switch (request.FilterType)
            {
                case 1: 
                    query = query.Where(x => x.Marca.ToLower() == request.String.ToLower());
                    break;
                case 2: 
                    query = query.Where(x => x.Submarca.ToLower() == request.String.ToLower());
                    break;
                case 0: 
                    break;
                default:
                    return BadRequest("El filtro solo funciona con valores null, 0, 1 y 2 ");
            }
        }

        var result = await query.ToListAsync();
        return Ok(result);
    }
}
