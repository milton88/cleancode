using System;

namespace ExercicioCleanCode.Exercicio01.Solucao3
{
    public class PrecoNegativoException : Exception
    {
        public PrecoNegativoException(string message) : base(message) { }
    }
}
