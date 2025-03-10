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
            var valida = true;

            if (datahora > DateTime.UtcNow)
            {
                valida = false;
            }                
            else if(datahora == DateTimeOffset.MinValue)
            {
                valida = false;
            }

            return valida;
        }

        public bool ValidarValor(decimal valor)
        {
            return valor >= 0;
        }

        #endregion
    }
}
