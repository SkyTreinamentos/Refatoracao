# **Exercício 11**
## Problema:
Uma classe referencia uma outra classe delegada por um objeto. Não pode-se navegar no grafo do objeto, essas regras de verificação e comportamento devem ser aplicadas na classe específica, apenas a própria classe tem permissão para mudar os seus atributos.

## Solução:
Solução: Com base no método "Ocultar Delegação", criar métodos na classe servidor para ocultar a delegação.

## Passos a serem executados:
1) Criar método Pagar na classe cliente, mover esse código para esse novo método. Em seguida substituir no método PagarConta (“Ocultar Delegação”).

        public class Cliente
        {
            private readonly Carteira carteira;

            public bool Pagar(double valorAPagar)
            {
                if (carteira.Total > valorAPagar) 
                {                           
                    carteira.RetirarDinheiro(valorAPagar);
                    return true;
                }
                return false;
            }
        }

        public void PagarConta(double valorAPagar)
        {
            if (cliente.Pagar(valorAPagar))
            {                
            }
            else
            {
                // volte quando tiver dinheiro para pagar
            }    
        }

2) Inverter a condicional no método PagarConta, removendo o else ("Decompor Condicional").

        public void PagarConta(double valorAPagar)
        {
            if (!cliente.Pagar(valorAPagar))
            {            
                // volte quando tiver dinheiro para pagar                
            }
        }

3) Inverter a condicional no método Pagar, removendo o else ("Decompor Condicional").
        
        public bool Pagar(double valorAPagar)
        {
            if (Carteira.Total < valorAPagar) 
                return false
                                       
            Carteira.RetirarDinheiro(valorAPagar);            
            return true;
        }