# **Exercício 04**
## Problema:
Está sendo usada uma variável temporária para armazenar o resultado de uma expressão. 

## Solução:
Com base no método "Substituir Variável Temporária por Consulta", extrair a expressão para um método. Substituir as referências à variável temporária pela expressão. Utilizar outros métodos de refatoração aprendidos para refatorar a função.

## Passos a serem executados:
1) Extrair expressão da variável para um método (“Extrair Método”).

        public double CalcularDesconto()
        {
            double precoBase = ObterPrecoBase();

            if (precoBase > 1000)
                return precoBase * 0.91;
            else    
                return precoBase * 0.98;
        }

        private double ObterPrecoBase()
        {
	        return quantidade * precoDoItem;
        }

2) Substituir todas as referências da variável temporária pelo método criado e remover variável (“Substituir Variável Temporária por Consulta”).

        public double CalcularDesconto()
        {
            if (ObterPrecoBase() > 1000)
                return ObterPrecoBase() * 0.91;
            else    
                return ObterPrecoBase() * 0.98;
        }

3) Extrair expressões para métodos (“Extrair Método”), remover o “else” (“Decompor Condicional”) e mover os valores fixos e substituir por constantes (“Substituir Números Mágicos por Constantes”). 