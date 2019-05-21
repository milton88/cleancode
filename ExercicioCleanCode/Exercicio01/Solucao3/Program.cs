using System;

namespace ExercicioCleanCode.Exercicio01.Solucao3
{
    public class Program
    {
        public static void Execute()
        {
            IDesconto desconto;
            desconto = new DescontoPlatinum();

            ICliente cliente;
            cliente = new Cliente(desconto);

            var calculadoraDescontos = new CalculadoraDescontos(cliente);
            var precoComDesconto = calculadoraDescontos.CalcularPrecoFinal(10);

            Console.WriteLine("Preço com desconto = " + precoComDesconto);
        }
    }
}
