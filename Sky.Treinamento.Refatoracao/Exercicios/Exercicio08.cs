namespace Sky.Treinamento.Refatoracao.Exercicios
{
    /// <summary>
    /// Problema: Está lendo diversos valores de um objeto e passando esses valores como parâmetros em uma 
    /// chamada de método. 
    /// 
    /// Solução: Com base no método "Preservar o Objeto Inteiro", em vez de fazer isso, enviar o objeto inteiro.
    /// </summary>
    public class Boletim
    {
        public double RenderizarMedia(Notas notasParciais)
        {
            int nota1 = notasParciais.Nota1;
            int nota2 = notasParciais.Nota2;
            int nota3 = notasParciais.Nota3;
            int nota4 = notasParciais.Nota4;

            return CalcularMedia(nota1, nota2, nota3, nota4);
        }

        private double CalcularMedia(int nota1, int nota2, int nota3, int nota4)
        {
            return nota1 + nota2 + nota3 + nota4 / 4;
        }
    }    

    public struct Notas
    {
        public int Nota1 { get; set; }
        public int Nota2 { get; set; }
        public int Nota3 { get; set; }
        public int Nota4 { get; set; }
    }      
}
