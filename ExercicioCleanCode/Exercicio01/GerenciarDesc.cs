using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioCleanCode.Exercicio01
{
    /// <summary>
    /// Classe responsável por gerenciar desconto
    /// </summary>
    public class GerenciarDesc
    {
        /// <summary>
        /// Aplica desconto 
        /// </summary>
        /// <param name="price">preço</param>
        /// <param name="status">tipo do cliente
        /// 1 - Não registrado
        /// 2 - Cliente Simples
        /// 3 - Cliente Valioso
        /// 4 - Cliente Mais Valioso
        /// </param>
        /// <returns></returns>
        public decimal AplicaDesc(decimal price, int status)
        {
            decimal result = 0;

            if (status == 1) // Não registrado
            {
                if (price < 0)
                    throw new Exception("valor inválido");

                //Não tem desconto
                result = price;
            }
            else if (status == 2) //Cliente Simples
            {
                if (price < 0)
                    throw new Exception("valor inválido");

                //Aplica 5% de desconto
                result = price - (0.05m * price);
            }
            else if (status == 3) //Cliente Valioso
            {
                if (price < 0)
                    throw new Exception("valor inválido");

                //Aplica 10% de desconto
                result = price - (0.1m * price);
            }
            else if (status == 4) //Cliente Mais Valioso
            {
                if (price < 0)
                    throw new Exception("valor inválido");

                //Aplica 25% de desconto
                result = price - (0.2m * price);
            }

            return result;
        }
    }
}
