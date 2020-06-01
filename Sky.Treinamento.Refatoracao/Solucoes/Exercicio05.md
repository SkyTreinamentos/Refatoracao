# **Exercício 05**
## Problema:
No método CalcularPRecoPorProteina, há uma variável temporária que mais de uma vez recebe uma atribuição. 

## Solução:
Com base no método "Dividir Variável Temporária", criar uma variável temporária para cada atribuição.

## Passos a serem executados:
1) Isolar a primeira expressão para uma nova variável nomeada, para melhor entendimento (“Dividir Variável Temporária”).

        public double CalcularPrecoPorProteina(double precoPote)
        {
            double doses = pesoDaLata / pesoDaDose;
            double temp = doses * proteinasPorDose;
            temp = precoPote / temp;
            return temp;
        }

2) Isolar a segunda expressão para uma nova variável nomeada, para melhor entendimento (“Dividir Variável Temporária”).

        public double CalcularPrecoPorProteina(double precoPote)
        {
            double doses = pesoDaLata / pesoDaDose;
            double proteinas = doses * proteinasPorDose;
            double temp = precoPote / proteinas;
            return temp;
        }

3) Renomear a variável “temp”, para melhor entendimento.

        public double CalcularPrecoPorProteina(double precoPote)
        {
            double doses = pesoDaLata / pesoDaDose;
            double proteinas = doses * proteinasPorDose;
            double precoPorProteina = precoPote / proteinas;
            return precoPorProteina;
        }

4) Extrair expressão da variável “doses” para um método (“Extrair para Métodos”), remover variável e substituir todas as referências dessa variável pelo método (“Substituir Variável Temporária por Consulta”).

        public double CalcularPrecoPorProteina(double precoPote)
        {
            double proteinas = ObterDoses() * proteinasPorDose;
            double precoPorProteina = precoPote / proteinas;
            return precoPorProteina;
        }

        private double ObterDoses()
        {
            return pesoDaLata / pesoDaDose;
        }

5) Extrair expressão da variável “proteinas” para um método (“Extrair para Métodos”), remover variável e substituir todas as referências dessa variável pelo método (“Substituir Variável Temporária por Consulta”).

        public double CalcularPrecoPorProteina(double precoPote)
        {
            double precoPorProteina = precoPote / ObterProteinas();
            return precoPorProteina;
        }

        private double ObterProteinas()
        {
            return ObterDoses() * proteinasPorDose;
        }

6) Remover a variável “precoPorProteina”, pois é redundante ao nome do próprio método, e retornar a expressão atribuída.

        public double CalcularPrecoPorProteina(double precoPote)
        {
            return precoPote / ObterProteinas();            
        }
