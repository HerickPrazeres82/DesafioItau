using DesafioItau.Entities;
using DesafioItau.ModelResponse;
using DesafioItau.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesafioItau.Controllers
{
    public class EstatisticaController : BaseController
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
