using System;

namespace ExercicioCleanCode.Exercicio01.Solucao1
{
    public class ValorNegativoException : Exception
    {
        public ValorNegativoException() 
            : base("Valor inválido!") { }

        public ValorNegativoException(string message) 
            : base(message) { }

        public ValorNegativoException(string message, System.Exception inner) 
            : base(message, inner) { }
    }
}
