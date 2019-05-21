namespace ExercicioCleanCode.Exercicio01.Solucao3
{
    public class SemDesconto : IDesconto
    {
        public decimal Desconto
        {
            get { return 0; }
        }

        public decimal Calcular(decimal preco)
        {
            return Desconto * preco;
        }
    }
}
