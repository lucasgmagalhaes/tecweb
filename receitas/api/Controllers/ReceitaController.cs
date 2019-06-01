using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ReceitaController : ControllerBase
  {
    private readonly ReceitaService receitaService;

    public ReceitaController()
    {
      receitaService = new ReceitaService();
    }

    [HttpGet]
    public ActionResult<List<Receita>> Get()
    {
      return Ok(receitaService.Buscar());
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public ActionResult<Receita> Get(int id)
    {
      return Ok(receitaService.Buscar(id));
    }

    // POST api/values
    [HttpPost]
    public ActionResult Post([FromBody] Receita receita)
    {
      try
      {
        receitaService.CriarReceita(receita);
        return Ok("Receita criada com sucesso");
      }
      catch (Exception e)
      {
        return StatusCode(500, e.Message);
      }
    }

    // PUT api/values/5
    [HttpPut]
    public void Put([FromBody] Receita receita)
    {
      receitaService.AtualizarVotos(receita);
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      receitaService.DeletarReceita(id);
    }
  }
}
