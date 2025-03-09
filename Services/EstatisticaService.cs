using DesafioItau.Entities;
using DesafioItau.ModelResponse;

namespace DesafioItau.Services
{
    public static class EstatisticaService
    {
        public static EstatisticaResponse ObterDadosEstatisticos(List<Transacao> listaTransacoes)
        {
            EstatisticaResponse response = new();

            if (listaTransacoes == null || listaTransacoes.Count == 0)
            {
                response.Count = 0;
                response.Sum = 0;
                response.Avg = 0;
                response.Min = 0;
                response.Max = 0;
                return response;
            }

            response.Count = listaTransacoes!.Count;
            response.Sum = listaTransacoes!.Sum(p => p.Valor);
            response.Avg = listaTransacoes!.Average(p => p.Valor);
            response.Min = listaTransacoes!.Min(p => p.Valor);
            response.Max = listaTransacoes!.Max(p => p.Valor);
            
            return response;
        }
    }
}
