using Core.Entities;
using ApiTienda.Controllers;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APITienda.Controllers;
public class PaisController : BaseApiController
{
    private readonly IUnitOfWork unitofwork;

    public PaisController(IUnitOfWork unitofwork)
    {
        this.unitofwork = unitofwork;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<IEnumerable<Pais>>> Get()
    {
        var paises = await unitofwork.Paises.GetAllAsync();
        return Ok(paises);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<IActionResult> Get(int id)
    {
        var pais = await unitofwork.Paises.GetByIdAsync(id);
        return Ok(pais);
    }
}