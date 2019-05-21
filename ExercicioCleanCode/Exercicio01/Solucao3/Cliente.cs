namespace ExercicioCleanCode.Exercicio01.Solucao3
{
    public class Cliente : ICliente
    {
        private IDesconto _desconto;

        public Cliente(IDesconto desconto)
        {
            _desconto = desconto;
        }

        public decimal CalcularDesconto(decimal preco)
        {
            return preco - _desconto.Calcular(preco);
        }
    }
}
