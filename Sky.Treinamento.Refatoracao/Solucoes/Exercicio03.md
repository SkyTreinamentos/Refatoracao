# **Exercício 03**
## Problema:
A expressão condicional do método CalcularValorDaCorrida é um pouco complicada de entender. 

## Solução:
Utilizando o método "Introduzir Variável Explicativa", coloque a expressão, ou partes dela, em uma variável temporária cujo único objetivo é explicar o seu propósito. Aplicar também "Extrair método", entre outras refatorações.

## Passos a serem executados:
1) Colocar a expressão para uma variável para melhor explicar/compreender seu propósito.

        public double CalcularValorDaCorrida()
        {
            bool bandeiraDois = hora > 22 || hora < 6;
            if (bandeiraDois)
                return distancia * 3.90;
            else
                return distancia * 2.10;
        }

2) Extrair expressão de variável para um método e remover variável.

        public double CalcularValorDaCorrida()
        {
            if (BandeiraDois())
                return distancia * 3.90;
            else
                return distancia * 2.10;
        }   

        private bool BandeiraDois()
        {
            return hora > 22 || hora < 6;
        }

3) Extrair a expressão que calcula a bandeira dois para um método.

        public double CalcularValorDaCorrida()
        {
            if (BandeiraDois())
                return CalcularBandeiraDois();
            else
                return distancia * 2.10;
        }

        private double CalcularBandeiraDois()
        {
            return distancia * 3.90;
        }

4) Extrair a expressão que calcula a bandeira um para um método.

        public double CalcularValorDaCorrida()
        {
            if (BandeiraDois())
                return CalcularBandeiraDois();
            else
                return CalcularBandeiraUm();
        } 

        private double CalcularBandeiraUm()
        {
            return distancia * 2.10;
        }

5) Remover o “else” na função CalcularValorDaCorrida (método “Decompor Condicional”).

        public double CalcularValorDaCorrida()
        {
            if (BandeiraDois())
                return CalcularBandeiraDois();            
            return CalcularBandeiraUm();
        } 

6) Utilizando o método “Substituir Números Mágicos por Constantes”, extrair o valores fixos para constantes e substituí-los.
        