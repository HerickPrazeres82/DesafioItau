using System.Runtime.Intrinsics.X86;

namespace DesafioItau.ModelResponse
{
    public class EstatisticaResponse
    {
        public int Count { get; set; }

        public decimal Sum { get; set; }
        public decimal Avg { get; set; }
        public decimal Min { get; set; }
        public decimal Max { get; set; }
    }
}
