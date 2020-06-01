namespace Sky.Treinamento.Refatoracao.Exercicios
{
    public class Exercicio19
    {
        /// <summary>
        /// Problema: A função possui um if apenas para decidir qual atribuição realizar.
        /// 
        /// Solução: Com base no método “Introduzir Comando Ternário”, utilizar comando ternário para simplificar 
        /// retorno do método, 
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public double CalcularImposto(double valor)
        {
            double imposto = 0;            
            if (valor > 1000)
            {
                imposto = valor * 0.05;
            }
            else
            {
                imposto = valor * 0.02;
            }
            return imposto;
        }
    }    
}
