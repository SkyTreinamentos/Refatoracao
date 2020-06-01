# **Exercício 22**
## Problema:
A exceção está sendo lançada sem uma mensagem contendo a explicação detalhada da falha. 

## Solução:
A partir do método “Exceções Lançadas Sem Informações de Captura”, defina uma mensagem detalhando a falha

## Passos a serem executados:
1) na classe BoletoInvalidoException, criar o método estático ObterMensagemDeErro, que receba o boleto e concatene as informações desse, detalhando a mensagem de erro. No construtor da classe, passar como parâmetro a classe Boleto, e também passando como parâmetro para a classe base Exception a chamada do método criado.

        public class BoletoInvalidoException : Exception
        {
	        public BoletoInvalidoException(Boleto boleto) : 
                base(ObterMensagemDeErro(boleto))
	        {
	        }

	        private static string ObterMensagemDeErro(Boleto boleto)
	        {
		        return $"Não foi possível gerar o Boleto. " + 
                        $"Cedente: {boleto.Cedente}, " + 
                        $"Sacado: {boleto.Sacado}, " + 
                        $"Valor: {boleto.Valor}";
	        }
        }

2) No lançamento de exceção, passar o objeto boleto.

        public void GerarBoleto(Boleto boleto)
        {            
            // código de geração de boletos
            throw new BoletoInvalidoException(boleto);
        }