# **Exercício 09**
## Problema:
A classe possui um método longo que usa variáveis locais de um modo que você não pode aplicar o "Extrair Método", pois isso tornará a classe maior ainda.

## Solução:
Com base no método "Substituir Método por Objeto Método", transforme o método em um objeto de modo que todas as variáveis locais do método se tornem campos desse objeto.

## Passos a serem executados:
1) Pegar os parâmetros do método e criar nova classe com esses atributos, além de um atributo Conta, afim de reutilizar métodos da classe Conta.

        public class Gama
        {
            private readonly Conta conta;
            private readonly int valorEntrada; 
            private readonly int quantidade; 
            private readonly int anoCorrente;

            public Gama(Conta conta, int valorEntrada, int quantidade, int anoCorrente)
            {
                this.conta = conta;
                this.valorEntrada = valorEntrada;
                this.quantidade = quantidade;
                this.anoCorrente = anoCorrente;
            }
        }

2) Criar nessa classe o método “Calcular” e mover o código do método “ObterGama” para esse novo método

        public double Calcular()
        {
            int valorImportante1 = (valorEntrada * quantidade) + conta.ObterDelta();

            int valorImportante2 = (valorEntrada * quantidade) + 100;

            if ((anoCorrente - valorImportante1) > 100)
                valorImportante2 -= 20;

            int valorImportante3 = valorImportante2 * 7;

            return valorImportante3 - valorImportante2 * valorImportante1;
        }

3) Alterar o método “ObterGama”, substituindo tudo pela instanciação da classe Gama e chamada do método Calcular.

        public double ObterGama(int valorEntrada, int quantidade, int anoCorrente)
        {
            return new Game(this, valorEntrada, quantidade, anoCorrente).Calcular();
        }

4) Mover expressão da variável “valorImportante1” para método (“Extrair para Métodos”), e substituir o uso da variável “valorImportante1” em outras expressões pela chamada do método e em seguida remover essa variável (“Substituir Variável Temporária por Consulta”).

        public double Calcular()
        {
            int valorImportante2 = (valorEntrada * quantidade) + 100;

            if ((anoCorrente - ObterValorImportante1()) > 100)
                valorImportante2 -= 20;

            int valorImportante3 = valorImportante2 * 7;

            return valorImportante3 - valorImportante2 * ObterValorImportante1();
        }

        private int ObterValorImportante1()
        {
            return (valorEntrada * quantidade) + conta.ObterDelta();
        }

5) Mover expressão da variável “valorImportante2” para método (“Extrair para Métodos”), e substituir o uso da variável “valorImportante2” em outras expressões pela chamada do método e em seguida remover essa variável (“Substituir Variável Temporária por Consulta”).

        public double Calcular()
        {
            int valorImportante3 = ObterValorImportante2() * 7;

            return valorImportante3 - ObterValorImportante2() * ObterValorImportante1();
        }

        private int ObterValorImportante2()
        {
            int valorImportante2 = (valorEntrada * quantidade) + 100;

            if ((anoCorrente - ObterValorImportante1()) > 100)
                valorImportante2 -= 20;

            return valorImportante2;
        }

6) Mover expressão da variável “valorImportante3” para método (“Extrair para Métodos”), substituir o uso da variável “valorImportante3” em outras expressões pela chamada do método e em seguida remover essa variável (“Substituir Variável Temporária por Consulta”).

        public double Calcular()
        {
            return ObterValorImportante3() - ObterValorImportante2() * ObterValorImportante1();
        }

        private int ObterValorImportante3()
        {
            return ObterValorImportante2() * 7;
        }
