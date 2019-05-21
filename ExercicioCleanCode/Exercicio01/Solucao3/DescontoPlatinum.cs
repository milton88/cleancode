namespace ExercicioCleanCode.Exercicio01.Solucao3
{
    public class DescontoPlatinum : IDesconto
    {
        public decimal Desconto
        {
            get { return 0.2m; }
        }

        public decimal Calcular(decimal preco)
        {
            return Desconto * preco - 0.3m;
        }
    }
}
