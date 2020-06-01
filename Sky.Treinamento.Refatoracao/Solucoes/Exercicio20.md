# **Exercício 20**
## Problema:
Está sendo lançado uma exceção genérica.

## Solução:
Com base no método “Evite Lançar Exceções Genéricas”, refatore o código lançando uma exceção específica.

## Passos a serem executados:
1) Substituir a exceção genérica por uma específica do framework (ArgumentOutOfRangeException) ou por uma de negócio criada para esse propósito.

        public void CalcularImposto(double salario)
        {
            if (salario < 0)
                throw new SalarioNegativoException("Salário não pode ser negativo.");

            // código de cálculo do imposto retido na fonte
            throw new NotImplementedException();
        }

2) Extrair a expressão condicional para um método (“Extrair Método”).
