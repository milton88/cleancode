namespace ExercicioCleanCode.Exercicio01.Solucao3
{
    public class DescontoSimples : IDesconto
    {
        public decimal Desconto
        {
            get { return 0.05m; }
        }

        public decimal Calcular(decimal preco)
        {
            return Desconto * preco - 0.1m;
        }
    }
}
