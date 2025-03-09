using DesafioItau.Entities;
using DesafioItau.ModelRequest;
using DesafioItau.ModelResponse;
using DesafioItau.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesafioItau.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransacaoController : ControllerBase
    {
        private List<Transacao> _transacoes { get; set; } = [];

        [HttpPost]
        public IActionResult RealizarTransacao([FromBody] TransacaoRequest transacaoRequest)
        {
            _transacoes = TransacaoService.ObterTransacoes();

            var transacaoResponse = TransacaoService.CriarTransacao(transacaoRequest);

            if(transacaoResponse.StatusCode != 201)
            {
                if (transacaoResponse.StatusCode == 422)
                    return UnprocessableEntity();

                return BadRequest();
            }

            return Created();
        }

        [HttpDelete]
        public IActionResult DeletarTransacao()
        {
            TransacaoService.DeletarTransacao();

            return Ok();
        }
    }
}
