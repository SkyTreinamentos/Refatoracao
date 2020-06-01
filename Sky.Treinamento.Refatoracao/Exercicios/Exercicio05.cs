namespace Sky.Treinamento.Refatoracao.Exercicios
{
    /// <summary>
    /// Problema: No método CalcularPRecoPorProteina, há uma variável temporária que mais de uma vez 
    /// recebe uma atribuição. 
    /// 
    /// Solução: Com base no método "Dividir Variável Temporária", criar uma variável temporária para cada atribuição.
    /// </summary>
    public class LataDeSuplementos
    {
        private readonly int pesoDaLata;
        private readonly int pesoDaDose;
        private readonly int proteinasPorDose;

        public double CalcularPrecoPorProteina(double precoPote)
        {
            double temp = pesoDaLata / pesoDaDose;
            temp = temp * proteinasPorDose;
            temp = precoPote / temp;
            return temp;
        }  
    }    
}
