namespace ExercicioCleanCode.Exercicio01.Solucao3
{
    public interface IDesconto
    {
        decimal Desconto { get; }
        decimal Calcular(decimal preco);
    }
}
