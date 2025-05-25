using DesafioItau.Entities;
using DesafioItau.ModelRequest;
using DesafioItau.ModelResponse;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

namespace DesafioItau.Services
{
    public static class TransacaoService
    {
        private static readonly List<Transacao> _transacoes = [];

        public static List<Transacao> ObterTransacoes()
        {
            return _transacoes;
        }

        public static TransacaoResponse CriarTransacao(TransacaoRequest transacaoRequest)
        {
            var dataHoraValida = transacaoRequest.ValidarDataHora(transacaoRequest.DataHora);
            var valorValido = transacaoRequest.ValidarValor(transacaoRequest.Valor);

            TransacaoResponse response = new();

            if (!valorValido || !dataHoraValida)
            {
                response.StatusCode = 422;                
                return response;
            }               

            response.StatusCode = 201;
            _transacoes.Add(new Transacao(valor: transacaoRequest.Valor, dataHora: transacaoRequest.DataHora));
            
            return response;

        }

        public static void DeletarTransacao()
        {
            _transacoes.Clear();
        }
    }
}
