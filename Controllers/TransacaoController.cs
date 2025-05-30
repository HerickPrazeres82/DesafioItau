﻿using DesafioItau.Entities;
using DesafioItau.ModelRequest;
using DesafioItau.ModelResponse;
using DesafioItau.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesafioItau.Controllers
{
    public class TransacaoController : BaseController
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
            }

            return Ok(transacaoRequest);
        }

        [HttpDelete]
        public IActionResult DeletarTransacao()
        {
            TransacaoService.DeletarTransacao();

            return Ok();
        }
    }
}
