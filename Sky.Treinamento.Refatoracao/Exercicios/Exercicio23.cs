using System;

namespace Sky.Treinamento.Refatoracao.Exercicios
{
    /// <summary>
    /// Problema: O método ProcessarSaque da classe ContaBancaria retorna um código especial para indicar um erro.
    /// 
    /// Solução: Ao invés disso, utilizando o método “Substituir Código de Erro por Exceção”, 
    /// refatorar o código para que gere uma exceção.
    /// </summary>
    
    public class CaixaEletronico
    {
        public readonly ContaBancaria conta;

        public CaixaEletronico(ContaBancaria conta)
        {
            this.conta = conta;
        }

        public void SacarDinheiro(double quantia)
        {            
            int resultado = conta.ProcessarSaque(quantia);

            if (resultado == 0)
            {
                DispensarDinheiro(quantia);
            }
            else if (resultado == -1)
            {
                ExibirMensagem("Saldo insuficiente");
            }
        }

        private void ExibirMensagem(string mensagem)
        {            
            throw new NotImplementedException();
        }

        private void DispensarDinheiro(double quantia)
        {            
            throw new NotImplementedException();
        }
    }

    public class ContaBancaria
    {
        private double Saldo { get; set; }

        public int ProcessarSaque(double quantia)
        {
            if (quantia <= Saldo)
            {
                Saldo -= quantia;
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }    
}
