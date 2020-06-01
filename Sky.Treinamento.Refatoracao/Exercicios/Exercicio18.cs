using System;

namespace Sky.Treinamento.Refatoracao.Exercicios
{
    public class Exercicio18
    {
        /// <summary>
        /// Problema: Método seleciona diferentes comportamentos de acordo com uma determinada condição. 
        /// Sempre que houver necessidade de novo tipo de extrato, será necessário criar um novo "else if"
        /// nesse método (além de implementar a lógica de emissão de extrato).
        /// 
        /// Solução: Com base no método “Substituir Comando Condicional por Polimorfismo”, mova cada ramificação
        /// do comando condicional para um método de sobrescrita e uma subclasse. Torne abstrato o método original.        
        /// </summary>
        /// <returns></returns>
        public void EmitirExtrato(string tipo)
        {
            if (tipo.Equals("SimplificadoMensal"))
            {
                // Código para emissão do extrato simplificado mensal 
                throw new NotImplementedException();
            }
            else if (tipo.Equals("SimplificadoQuinzenal"))
            {
                // Código para emissão do extrato simplificado quinzenal 
                throw new NotImplementedException();
            }
            else if (tipo.Equals("SimplificadoSemanal"))
            {
                // Código para emissão do extrato simplificado semanal 
                throw new NotImplementedException();
            }
            else if (tipo.Equals("Completo"))
            {
                // Código para emissão do extrato completo 
                throw new NotImplementedException();
            }
        }
    }
}
