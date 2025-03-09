namespace DesafioItau.Entities
{
    public class Transacao(decimal valor, DateTimeOffset dataHora)
    {
        public decimal Valor { get; set; } = valor;
        public DateTimeOffset DataHora { get; set; } = dataHora;
    }
}
