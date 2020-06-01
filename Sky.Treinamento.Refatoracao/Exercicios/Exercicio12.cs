namespace Sky.Treinamento.Refatoracao.Exercicios
{
    /// <summary>
    /// Problema: A classe possui muitos construtores que fazem coisas diferentes. 
    /// 
    /// Solução: Com base no método “Substituindo Construtor por Método Fábrica”, utilizar métodos fábrica para tornar 
    /// a construção mais intuitiva, criando métodos específicos para cada tipo de triângulo denominado-os conforme 
    /// a regra de negócio, retornando um objeto do tipo Triângulo.
    /// </summary>
    public class Triangulo
    {
        private readonly int lado1;
        private readonly int lado2;
        private readonly int lado3;

        public Triangulo(int tamanho)
        {
            lado1 = tamanho;
            lado2 = tamanho;
            lado3 = tamanho;
        }

        public Triangulo(int tamanho1, int tamanho2)
        {
            lado1 = tamanho1;
            lado2 = tamanho2;
            lado3 = tamanho2;
        }

        public Triangulo(int tamanho1, int tamanho2, int tamanho3)
        {
            lado1 = tamanho1;
            lado2 = tamanho2;
            lado3 = tamanho3;
        }
    }    
}
