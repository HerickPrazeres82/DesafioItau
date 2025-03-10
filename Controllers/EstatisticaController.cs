using DesafioItau.Entities;
using DesafioItau.ModelResponse;
using DesafioItau.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesafioItau.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EstatisticaController : ControllerBase
    {
        private List<Transacao> _transacoes = [];

        [HttpGet]
        public IActionResult ObterEstatisticas()
        {
            _transacoes = TransacaoService.ObterTransacoes();

            var response = EstatisticaService.ObterDadosEstatisticos(_transacoes);            

            return Ok(response);
        }

    }
}
