namespace ExercicioCleanCode.Exercicio01.Solucao3
{
    public class CalculadoraDescontos
    {
        private ICliente _cliente;

        public CalculadoraDescontos(ICliente cliente)
        {
            _cliente = cliente;
        }

        public decimal CalcularPrecoFinal(decimal preco)
        {
            if (preco <= 0)
                throw new PrecoNegativoException("O preço informado precisa ser maior que zero!");

            return preco - _cliente.CalcularDesconto(preco);
        }
    }
}
