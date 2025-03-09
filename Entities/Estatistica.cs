namespace DesafioItau.Entities
{
    public class Estatistica(int count, decimal sum, decimal avg, decimal min, decimal max)
    {
        public int Count { get; set; } = count;
        public decimal Sum { get; set; } = sum;
        public decimal Avg { get; set; } = avg;
        public decimal Min { get; set; } = min;
        public decimal Max { get; set; } = max;
    }
}
