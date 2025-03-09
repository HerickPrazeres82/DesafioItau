namespace DesafioItau.ModelRequest
{
    public class TransacaoRequest
    {
        public TransacaoRequest() { }

        public decimal Valor { get; set; }
        public DateTimeOffset DataHora { get; set; }

        #region Validações
        public bool ValidarDataHora(DateTimeOffset datahora)
        {
            var result = true;

            if (datahora > DateTime.UtcNow)
                result = false;

            return result;
        }

        public bool ValidarValor(decimal valor)
        {
            var result = true;

            if (valor < 0)
                result = false;

            return result;
        }

        #endregion
    }
}
