namespace Sky.Treinamento.Refatoracao.Exercicios
{
    /// <summary>
    /// Problema: O código está fazendo atribuições a parâmetros. 
    /// 
    /// Solução: Com base no método "Remover Atribuições a Parâmetros", refatorar código utilizando uma variável temporária no lugar da atribuição.
    /// </summary>
    public class ExercicioSeis
    {
        public void ObterDesconto(Compra compra)
        {
            if (compra.QuantidadeDeProdutos > 60)
                compra.Desconto = 0.10;
        }
    }    

    public struct Compra
    {
        public uint QuantidadeDeProdutos { get; set; }
        public double Desconto { get; set; }
    }
}
