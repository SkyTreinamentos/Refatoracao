using System;

namespace Sky.Treinamento.Refatoracao.Exercicios
{
    /// <summary>
    /// Problema: Uma classe referencia uma outra classe delegada por um objeto. Não pode-se navegar no grafo 
    /// do objeto, essas regras de verificação e comportamento devem ser aplicadas na classe específica, apenas
    ///  a própria classe tem permissão para mudar os seus atributos.
    /// 
    /// Solução: Com base no método "Ocultar Delegação", criar métodos na classe servidor para ocultar a delegação.
    /// </summary>
    public class ExercicioOnze
    {
        private readonly Cliente cliente;        

        public void PagarConta(double valorAPagar)
        {
            if (cliente.Carteira.Total > valorAPagar)
            {
                cliente.Carteira.RetirarDinheiro(valorAPagar);
            }
            else
            {
                // volte quando tiver dinheiro para pagar
            }    
        }
    }

    public class Cliente
    {
        public Carteira Carteira { get; set; }        
    }

    public class Carteira
    {
        public double Total { get; set; }

        public void RetirarDinheiro(double valorAPagar)
        {
            throw new NotImplementedException();
        }
    }    
}
