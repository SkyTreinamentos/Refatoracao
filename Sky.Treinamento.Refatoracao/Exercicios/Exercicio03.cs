namespace Sky.Treinamento.Refatoracao.Exercicios
{
    /// <summary>    
    /// Problema: A expressão condicional do método CalcularValorDaCorrida é um pouco complicada de entender. 
    /// 
    /// Solução: Utilizando o método "Introduzir Variável Explicativa", coloque a expressão, ou partes dela, em uma 
    /// variável temporária cujo único objetivo é explicar o seu propósito. Aplicar também "Extrair método", entre
    /// outros métodos para refatorar o método.
    /// </summary>
    public class CorridaDeTaxi
    {
        private readonly int hora;
        private readonly uint distancia;

        public CorridaDeTaxi(int hora, uint distancia)
        {
            this.hora = hora;
            this.distancia = distancia;
        }

        public double CalcularValorDaCorrida()
        {
            if (hora > 22 || hora < 6)
                return distancia * 3.90;
            else
                return distancia * 2.10;
        }        
    }    
}
