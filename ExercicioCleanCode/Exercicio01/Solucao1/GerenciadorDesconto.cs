namespace ExercicioCleanCode.Exercicio01.Solucao1
{
    public class GerenciadorDesconto
    {
        public decimal AplicarDescontoPorTipoCliente(decimal valor, ClienteTipo tipo)
        {
            Validar(valor);
            decimal percentualDesconto = ObterPercentualDescontoPorTipoCliente(tipo);
            decimal valorComDesconto = CalcularValorComDesconto(valor, percentualDesconto);
            return valorComDesconto;
        }

        private decimal ObterPercentualDescontoPorTipoCliente(ClienteTipo tipo)
        {
            decimal zeroPorcento = 0m;
            decimal cincoPorcento = 0.05m;
            decimal dezPorcento = 0.10m;
            decimal vintePorcento = 0.20m;

            switch (tipo)
            {
                case ClienteTipo.NaoRegistrado:
                    return zeroPorcento;
                case ClienteTipo.Simples:
                    return cincoPorcento;
                case ClienteTipo.Valioso:
                    return dezPorcento;
                case ClienteTipo.MaisValioso:
                    return vintePorcento;
                default:
                    return zeroPorcento;
            }
        }

        private decimal CalcularValorComDesconto(decimal valor, decimal percentualDesconto)
        {
            return valor - (percentualDesconto * valor);
        }

        private void Validar(decimal valor)
        {
            if (valor <= 0)
                throw new ValorNegativoException();
        }
    }
}
