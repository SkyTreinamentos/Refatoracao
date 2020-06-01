using System;

namespace Sky.Treinamento.Refatoracao.Exercicios
{
    /// <summary>
    /// 
    /// Problema: O método ConverterVideo está lançando uma exceção customizada para tratar um cenário específico (objeto == null). 
    /// 
    /// Solução: Substitua a exceção customizada pela padrão do framework.
    /// </summary>
    public class Exercicio24
    {
        public void ConverterVideo(Video video)
        {
            if (video == null)
                throw new VideoInvalidoException("O vídeo é nulo");
            // código da conversão do vídeo
        }
    }

    public class Video
    {        
    }

    public class VideoInvalidoException : Exception
    { 
        public VideoInvalidoException(string mensagem) : base(mensagem)
        {            
        }
    }
}
