namespace Sky.Treinamento.Refatoracao.Exercicios
{
    /// <summary>
    /// Problema: O método possui uma sequencia de testes com o mesmo resultado. Muitos ifs encadeados deixam código mais distante da margem, tornando-o mais complexo. 
    /// 
    /// Solução: Com base no método "Consolidar Expressão Condicional", consolide-os em uma única expressão e extraia-a.
    /// </summary>
    public class Exercicio15
    {
        private readonly bool estudante;
        private readonly bool temCarteirinha;
        private readonly bool naoEFalsa;

        public double CalcularEntrada(double valor)
        {
            if (estudante)
            {            
                if (temCarteirinha)    
                {
                    if (naoEFalsa)
                    {
                        return valor * 0.5;                    
                    }
                }
            }

            return valor;
        }
    }
}