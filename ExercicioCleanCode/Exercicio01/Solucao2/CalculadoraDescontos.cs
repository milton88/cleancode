using System;

namespace ExercicioCleanCode.Exercicio01.Solucao2
{
    public class CalculadoraDescontos
    {
        private ICliente _cliente;

        public CalculadoraDescontos(ICliente cliente)
        {
            _cliente = cliente;
        }

        public decimal Calcular(decimal preco)
        {
            if (preco <= 0)
                throw new PrecoNegativoException("O preço informado precisa ser maior que zero!");

            var totalDesconto = _cliente.Desconto * preco;
            return preco - totalDesconto;
        }
    }
}
