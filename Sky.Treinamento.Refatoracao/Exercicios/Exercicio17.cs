using System;

namespace Sky.Treinamento.Refatoracao.Exercicios
{
    /// <summary>
    /// Problema: Método tem uma lógica condicional que não deixa claro o fluxo normal da execução. Possui muitos ifs 
    /// aninhados e lógica condicional que não deixa claro o fluxo normal da execução. 
    /// 
    /// Solução: Com base no método “Remover Condição Aninhada por Cláusulas Guarda”, usar cláusulas-guarda para todos 
    /// os casos especiais.
    /// </summary>
    public class Caixa
    {
        private bool CaixaFechado { get; set; }
        private double Saldo { get; set; }
        private DateTime DataAberturaCaixa { get; set; }

        public bool FecharCaixa(DateTime hoje)
        {
            if (!CaixaFechado)            
            {

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
            else
            {
                return true;
            }
            
        }

        public void TransferirDinheiroParaContaBancaria(double valor)
        {
            throw new NotImplementedException();
        }
    }    

    public class DataRetroativaException : Exception
    {        
    }

    public class SaldoNegativoException : Exception
    {        
    }
}
