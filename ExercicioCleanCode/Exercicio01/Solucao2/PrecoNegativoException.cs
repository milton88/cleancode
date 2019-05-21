using System;

namespace ExercicioCleanCode.Exercicio01.Solucao2
{
    public class PrecoNegativoException : Exception
    {
        public PrecoNegativoException(string message) : base(message) { }
    }
}
