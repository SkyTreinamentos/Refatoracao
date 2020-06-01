# **Exercício 23**
## Problema:
O método **ProcessarSaque** da classe ContaBancaria retorna um código especial para indicar um erro.

## Solução:
Utilizando o método **“Substituir Código de Erro por Exceção”**, refatorar o código para que gere uma exceção.

## Passos a serem executados:
1) Implementar a classe SaldoInsuficienteException para especificar essa exceção.
    
        public class SaldoInsuficienteException : Exception
        {        
            public SaldoInsuficienteException(string mensagem = "Saldo insuficiente") : 
                base(mensagem)
            {            
            }
        }

2) Alterar retorno do método ProcessarSaque para void, remover retorno do then e substituir o retorno do else pelo lançamento da exceção.

        public void ProcessarSaque(double quantia)
        {
            if (quantia <= Saldo)
            {
                Saldo -= quantia;                
            }
            else
            {
                throw new SaldoInsuficienteException();
            }
        }

3) No método SacarDinheiro, remover atribuição em variável temporária e condicionais.

        public void SacarDinheiro(double quantia)
        {   
            conta.ProcessarSaque(quantia);
            DispensarDinheiro(quantia);
            ExibirMensagem("Saldo insuficiente");            
        }

4) No mesmo método, incluir bloco try catch, capturando a SaldoInsuficienteException.

        public void SacarDinheiro(double quantia)
        {   
            try
            {         
                conta.ProcessarSaque(quantia);
                DispensarDinheiro(quantia);
            }
            catch(SaldoInsuficienteException exception)
            {
                ExibirMensagem(exception.Message);
            }
        }

5) “Decompor Condicional” do método ProcessarSaque, invertendo a expressão condicional.

        public void ProcessarSaque(double quantia)
        {
            if (quantia > Saldo)
                throw new SaldoInsuficienteException();            
            Saldo -= quantia;            
        }

6) "Extrair Método" da expressão condicional.

        public void ProcessarSaque(double quantia)
        {
            if (SaldoInsuficiente(quantia))
                throw new SaldoInsuficienteException();            
            Saldo -= quantia;            
        }

        private bool SaldoInsuficiente(double quantia)
        {
            return quantia > Saldo;
        }

7) "Extrair Método" da operação de saque.

        public void ProcessarSaque(double quantia)
        {
            if (SaldoInsuficiente(quantia))
                throw new SaldoInsuficienteException();            
            RealizarSaque(quantia);            
        }

        private void RealizarSaque(double quantia)
        {
            Saldo -= quantia;
        }
