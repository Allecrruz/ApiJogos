using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Controller.V1
{
    [Route("api/V1/[controller]")]
    [ApiController]
    public class JogosController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<JogoViewModel>>>Obter()
        {
            return Ok ();
        }

        [HttpGet("{idJogo:guid}")]

        public async Task<ActionResult<JogoViewModel>>Obter(Guid idJogo)
        {
            return Ok ();


        [HttpPost]
        public async  Task<ActionResult<List<JogoViewModel>>> InserirJogo(JogoInputModel jogo) 
        {
               return Ok();
        }

        }

        [HttpPut ("{idJogo:guid}")]
    }   public async  Task<ActionResult>AtualizarJogo(Guid idJogo, JogoInputModel jogo)
        {
            return ok();
        }

        [HttpPatch ("{idJogo:guid}/preco{preco:double}")]
         public async  Task<ActionResult>AtualizarJogo(Guid idJogo, double preco)
        {
            return ok();
        }

        [HttpDelete ("{idJogo:guid}")]
        public async  Task<AcceptedResult>ApagarJogo(Guid idJogo)
        {
            return ok();
        }
}
