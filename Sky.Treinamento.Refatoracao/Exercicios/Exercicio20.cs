using System;

namespace Sky.Treinamento.Refatoracao.Exercicios
{
    public class Exercicio20
    {
        /// <summary>
        /// Problema: Está sendo lançado uma exceção genérica.
        /// 
        /// Solução: Com base no método “Evite Lançar Exceções Genéricas”, refatore o código lançando uma exceção específica.
        /// </summary>
        /// <param name="salario"></param>

        public void CalcularImposto(double salario)
        {
            if (salario < 0)
                throw new Exception("Salário não pode ser negativo.");

            // código de cálculo do imposto retido na fonte
            throw new NotImplementedException();
        }
    }   
}
