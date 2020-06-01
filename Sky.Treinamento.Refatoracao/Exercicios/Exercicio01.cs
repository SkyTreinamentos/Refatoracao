namespace Sky.Treinamento.Refatoracao.Exercicios
{
    public class Fisica
    {
        /// <summary>
        /// Problema: Há um número literal com um significado especial, não entendível. 
        /// 
        /// Solução: Com base no método "Substituir Números Mágicos por Constantes", crie uma constante, nomeie-a de 
        /// acordo com o seu significado e substitua o número por ele.
        /// </summary>
        /// <param name="massa"></param>
        /// <param name="altura"></param>
        /// <returns></returns>
        public double ObterEnergiaPotencial(double massa, double altura)
        {
            return massa * 9.81 * altura;
        }
    }
}
