using System;

namespace ExercicioCleanCode.Exercicio01.Solucao1
{
    public class Program
    {
        public static void Execute()
        {
            // var opcao = '1';
            // var opcao = '2';
            // var opcao = '3';
            var opcao = '4';

            var gerenciadorDesconto = new GerenciadorDesconto();
            var valor = 100m;

            switch (opcao)
            {
                case '1':
                    Console.WriteLine(gerenciadorDesconto.AplicarDescontoPorTipoCliente(valor, ClienteTipo.NaoRegistrado));
                    break;
                case '2':
                    Console.WriteLine(gerenciadorDesconto.AplicarDescontoPorTipoCliente(valor, ClienteTipo.Simples));
                    break;
                case '3':
                    Console.WriteLine(gerenciadorDesconto.AplicarDescontoPorTipoCliente(valor, ClienteTipo.Valioso));
                    break;
                case '4':
                    Console.WriteLine(gerenciadorDesconto.AplicarDescontoPorTipoCliente(valor, ClienteTipo.MaisValioso));
                    break;
            }
        }
    }
}
