using System;

namespace Sky.Treinamento.Refatoracao.Exercicios
{
    /// <summary>    
    /// Problema: Está sendo usada uma variável temporária para armazenar o resultado de uma expressão. 
    /// 
    /// Solução: Com base no método "Substituir Variável Temporária por Consulta", extrair a expressão para um método. 
    /// Substituir as referências à variável temporária pela expressão. Utilizar outros métodos de refatoração 
    /// aprendidos para refatorar a função.
    /// </summary>
    public class Exercicio04
    {
        private readonly uint quantidade;
        private readonly double precoDoItem;

        public double CalcularDesconto()
        {
            double precoBase = quantidade * precoDoItem;

            if (precoBase > 1000)
                return precoBase * 0.91;
            else    
                return precoBase * 0.98;
        }
    }
}
