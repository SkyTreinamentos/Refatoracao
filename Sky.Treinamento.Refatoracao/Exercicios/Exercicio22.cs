using System;

namespace Sky.Treinamento.Refatoracao.Exercicios
{
    public class Exercicio22
    {
        /// <summary>
        /// Problema: A exceção está sendo lançada sem uma mensagem contendo a explicação detalhada da falha. 
        /// 
        /// Solução: A partir do método “Exceções Lançadas Sem Informações de Captura”, 
        /// defina uma mensagem detalhando a falha.
        /// </summary>
        /// <param name="boleto"></param>
        public void GerarBoleto(Boleto boleto)
        {            
            // código de geração de boletos
            throw new BoletoInvalidoException();
        }
    }    

    public class Boleto
    {
        public string Cedente { get; set; }
        public string Sacado { get; set; }
        public double Valor { get; set; }
    }

    public class BoletoInvalidoException : Exception
    {
    }
}
