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

        public static TransacaoResponse CriarTransacao(this TransacaoRequest transacaoRequest)
        {
            var dataHoraValida = transacaoRequest.ValidarDataHora(transacaoRequest.DataHora);
            var valorValido = transacaoRequest.ValidarValor(transacaoRequest.Valor);

            TransacaoResponse response = new();

            if (!dataHoraValida)
            {
                response.StatusCode = 422;
                response.ErrorMessage = "A data da transação não pode estar no futuro.";
                return response;
            }               

            if(!valorValido)
            {
                response.StatusCode = 422;
                response.ErrorMessage = "O valor da transação deve ser igual ou maior que zero.";
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
