# **Exercício 15**
## Problema:
O método possui uma sequencia de testes com o mesmo resultado. Muitos ifs encadeados deixam código mais distante da 
margem, tornando-o mais complexo. 

## Solução:
Com base no método "Consolidar Expressão Condicional", consolide-os em uma única expressão e extraia-a.

## Passos a serem executados:
1) Mover as condicionais para a mesma condição.

        public double CalcularEntrada(double valor)
        {
            if (estudante && temCarteirinha && naoEFalsa)                
                return valor * 0.5;                                                
            return valor;
        }

2) Extrair a expressão condicional para um método (“Extrair Método”).

        public double CalcularEntrada(double valor)
        {
            if (AptoAPagarMeiaEntrada())                
                return valor * 0.5;                                                
            return valor;
        }

        private bool AptoAPagarMeiaEntrada()
        {
            return estudante && temCarteirinha && naoEFalsa;
        }

3) Extrair a expressão do cálculo da meia-entrada para um método (“Extrair Método”).

        public double CalcularEntrada(double valor)
        {
            if (AptoAPagarMeiaEntrada())                
                return CalcularMeiaEntrada();                                                
            return valor;
        }

        private double CalcularMeiaEntrada()
        {
            return valor * 0.5;
        }

4) Mover os valores fixos e substituir por constantes (“Substituir Números Mágicos por Constantes”).