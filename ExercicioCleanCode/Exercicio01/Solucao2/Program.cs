using System;

namespace ExercicioCleanCode.Exercicio01.Solucao2
{
    public class Program
    {
        public static void Execute()
        {
            ICliente cliente;

            cliente = new ClientePlatinum();

            var calculadoraDescontos = new CalculadoraDescontos(cliente);
            var precoComDesconto = calculadoraDescontos.Calcular(0.2m);
            Console.WriteLine("Preço com desconto = " + precoComDesconto);
        }
    }
}
