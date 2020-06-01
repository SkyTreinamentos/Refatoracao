using System;

namespace Sky.Treinamento.Refatoracao.Exercicios
{
    /// <summary>
    /// Problema: A classe possui um método longo que usa variáveis locais de um modo que você não pode aplicar 
    /// o "Extrair Método", pois isso tornará a classe maior ainda. 
    /// 
    /// Solução: Com base no método "Substituir Método por Objeto Método", transforme o método em um objeto de modo 
    /// que todas as variáveis locais do método se tornem campos desse objeto.
    /// </summary>
    public class Conta
    {
        public double ObterGama(int valorEntrada, int quantidade, int anoCorrente)
        {
            int valorImportante1 = (valorEntrada * quantidade) + ObterDelta();

            int valorImportante2 = (valorEntrada * quantidade) + 100;

            if ((anoCorrente - valorImportante1) > 100)
                valorImportante2 -= 20;

            int valorImportante3 = valorImportante2 * 7;

            return valorImportante3 - valorImportante2 * valorImportante1;
        }

        public int ObterDelta()
        {
            return new Random().Next();
        }
    }    
}
