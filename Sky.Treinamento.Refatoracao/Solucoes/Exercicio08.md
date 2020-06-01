# **Exercício 08**
## Problema:
Está lendo diversos valores de um objeto e passando esses valores como parâmetros em uma chamada de método. 

## Solução:
Com base no método "Preservar o Objeto Inteiro", em vez de fazer isso, enviar o objeto inteiro.

## Passos a serem executados:
1) Alterar a assinatura do método “CalcularMedia”, passando como parâmetro o próprio objeto (“Preservar o Objeto Inteiro”).
        
        private double CalcularMedia(Notas notasParciais)
        {
            return notasParciais.Nota1 + notasParciais.Nota2 + notasParciais.Nota3 + notasParciais.Nota4 / 4;
        }

2) Remover as variáveis temporárias e passar o objeto Notas na chamada do método CalcularMedia.

        public double RenderizarMedia(Notas notasParciais)
        {
            return CalcularMedia(notasParciais);
        }

