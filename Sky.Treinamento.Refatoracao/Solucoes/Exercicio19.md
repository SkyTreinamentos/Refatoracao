# **Exercício 19**
## Problema:
A função possui um if apenas para decidir qual atribuição realizar.

## Solução:
Com base no método “Introduzir Comando Ternário”, utilizar comando ternário para simplificar retorno do método, 

## Passos a serem executados:
1) Extrair a expressão condicional para um método (“Extrair Método”).

        public double CalcularImposto(double valor)
        {
            double imposto = 0;            
            if (ValorExcedente(valor))
            {
                imposto = valor * 0.05;
            }
            else
            {
                imposto = valor * 0.02;
            }
            return imposto;
        }

        private bool ValorExcedente(valor)
        {
            return valor > 1000;
        }

2) Extrair as expressões que calculam o imposto para métodos (“Extrair Método”).

        public double CalcularImposto(double valor)
        {
            double imposto = 0;            
            if (ValorExcedente(valor))
            {
                imposto = CalcularImpostoDeValorExcedente(valor);
            }
            else
            {
                imposto = CalcularImpostoDeValorPadrao(valor);
            }
            return imposto;
        }

        private double CalcularImpostoDeValorExcedente(valor)
        {
            return valor * 0.05;
        }

        private double CalcularImpostoDeValorPadrao(valor)
        {
            return valor * 0.02;
        }

3) Mover os valores fixos e substituir por constantes (“Substituir Números Mágicos por Constantes”).

4) Remover then e else e introduzir comando ternário para atribuição na variável imposto (“Introduzir Comando Ternário”).

        public double CalcularImposto(double valor)
        {
            double imposto = ValorExcedente(valor) ?
                CalcularImpostoDeValorExcedente(valor) :
                CalcularImpostoDeValorPadrao(valor);            
            return imposto;
        }

5) Remover a variável temporária e atribuir ao return.

        public double CalcularImposto(double valor)
        {
            return ValorExcedente(valor) ?
                CalcularImpostoDeValorExcedente(valor) :
                CalcularImpostoDeValorPadrao(valor);
        }