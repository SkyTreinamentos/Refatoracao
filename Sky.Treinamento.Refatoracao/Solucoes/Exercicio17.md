# **Exercício 17**
## Problema:
Método tem uma lógica condicional que não deixa claro o fluxo normal da execução. Possui muitos ifs aninhados e lógica condicional que não deixa claro o fluxo normal da execução. 

## Solução:
Com base no método “Remover Condição Aninhada por Cláusulas Guarda”, usar cláusulas-guarda para todos os casos especiais.

## Passos a serem executados:
1) Decompor o primeiro if condicional (“Decompor Condicional”), invertendo a condicional (remover o ponto de exclamação de negação).

        public bool FecharCaixa(DateTime hoje)
        {
            if (CaixaFechado)            
                return true;            

            if (Saldo > 0)
            {
                if (DataAberturaCaixa.Equals(hoje))
                {
                    TransferirDinheiroParaContaBancaria(Saldo);
                    return true;
                }
                else
                {
                    throw new DataRetroativaException();
                }
            }
            else
            {
                throw new SaldoNegativoException();
            }
        }

2) Fazer o mesmo para o segundo if condicional: “Decompor Condicional” invertendo a condicional.

        public bool FecharCaixa(DateTime hoje)
        {
            if (CaixaFechado)            
                return true;            

            if (Saldo < 0)
                throw new SaldoNegativoException();
            
            if (DataAberturaCaixa.Equals(hoje))
            {
                TransferirDinheiroParaContaBancaria(Saldo);
                return true;
            }
            else
            {
                throw new DataRetroativaException();
            }            
        }

3) Fazer o mesmo para o terceiro if condicional: “Decompor Condicional” invertendo a condicional.

        public bool FecharCaixa(DateTime hoje)
        {
            if (CaixaFechado)            
                return true;            

            if (Saldo < 0)
                throw new SaldoNegativoException();
            
            if (!DataAberturaCaixa.Equals(hoje))
                throw new DataRetroativaException();
            
            TransferirDinheiroParaContaBancaria(Saldo);
            return true;                        
        }

4) Extrair todas as expressões para métodos (“Extrair Método”).