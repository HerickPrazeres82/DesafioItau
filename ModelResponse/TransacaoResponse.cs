using DesafioItau.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DesafioItau.ModelResponse
{
    public class TransacaoResponse
    {
        public int StatusCode { get; set; }
        public string? ErrorMessage { get; set; }

    }
}
