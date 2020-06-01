# **Exercício 06**
## Problema:
O código está fazendo atribuições a parâmetros.

## Solução:
Com base no método "Remover Atribuições a Parâmetros", refatorar código utilizando uma variável temporária no lugar da atribuição.

## Passos a serem executados:
1) Alterar o método para que retorne double.

        public double ObterDesconto(Compra compra)
        {
            if (compra.QuantidadeDeProdutos > 60)
                compra.Desconto = 0.10;
            return 0.0;
        }

2) Remover a atribuição do valor, atribuído valor ao retorno do método (“Remover Atribuições a Parâmetros”).

        public double ObterDesconto(Compra compra)
        {
            if (compra.QuantidadeDeProdutos > 60)
                return 0.10;
            return 0.0;
        }

3) Extrair expressão condicional para um método ("Extrair Método"), mover os valores fixos e substituir por constantes (“Substituir Números Mágicos por Constantes”).
