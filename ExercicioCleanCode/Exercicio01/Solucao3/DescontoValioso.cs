namespace ExercicioCleanCode.Exercicio01.Solucao3
{
    public class DescontoValioso : IDesconto
    {
        public decimal Desconto
        {
            get { return 0.1m; }
        }

        public decimal Calcular(decimal preco)
        {
            return Desconto * preco - 0.2m;
        }
    }
}
