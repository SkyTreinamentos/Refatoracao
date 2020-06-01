# **Exercício 12**
## Problema:
A classe possui muitos construtores que fazem coisas diferentes. 

## Solução:
Com base no método “Substituindo Construtor por Método Fábrica”, utilizar métodos fábrica para tornar a construção mais intuitiva, criando métodos específicos para cada tipo de triângulo denominado-os conforme a regra de negócio, retornando um objeto do tipo Triângulo.

## Passos a serem executados:
1) Criar o método CriarTrianguloEquilatero com 1 parâmetro, substituindo/removendo o construtor de 1 parâmetro.

        public static Triangulo CriarTrianguloEquilatero(int tamanho)
        {
	        return new Triangulo(tamanho, tamanho, tamanho);
        }

2) Criar o método CriarTrianguloEquilatero com 2 parâmetros, substituindo/removendo o construtor de 2 parâmetros.

        public static Triangulo CriarTrianguloIsoceles(int tamanho1, int tamanho2)
        {
	        return new Triangulo(tamanho1, tamanho2, tamanho2);
        }

3) Criar o método CriarTrianguloEscaleno com 3 parâmetros.

        public static Triangulo CriarTrianguloEscaleno(int tamanho1, int tamanho2, int tamanho3)
        {
	        return new Triangulo(tamanho1, tamanho2, tamanho3);
        }

4) Alterar o construtor de 3 parâmetros para privado.

        private Triangulo(int tamanho1, int tamanho2, int tamanho3)
        {
            lado1 = tamanho1;
            lado2 = tamanho2;
            lado3 = tamanho3;
        }