# **Exercício 01**
## Problema:
Há um número literal com um significado especial, não entendível. 

## Solução:
Com base no método "Substituir Números Mágicos por Constantes", crie uma constante, nomeie-a de acordo com o seu significado e substitua o número por ele.

## Passos a serem executados:
1)  Criar uma constante e atribuir o valor “9.81” a essa constante. 

        private const double Gravidade = 9.81;


2) Em seguida substituir esse valor na expressão pelo nome da constante, tornando mais legível o que representa esse valor.

        public double ObterEnergiaPotencial(double massa, double altura)
        {
            return massa * Gravidade * altura;
        }