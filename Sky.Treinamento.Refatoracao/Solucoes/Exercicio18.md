# **Exercício 18**
## Problema:
Método seleciona diferentes comportamentos de acordo com uma determinada condição. Sempre que houver necessidade de novo tipo de extrato, será necessário criar um novo "else if" nesse método (além de implementar a lógica de emissão de extrato).

## Solução:
Com base no método “Substituir Comando Condicional por Polimorfismo”, mova cada ramificação do comando condicional para um método de sobrescrita e uma subclasse. Torne abstrato o método original.

## Passos a serem executados:
1) Criar enumerador para os tipos de extratos.

        public enum Extratos
        {
	        Completo,
	        SimplificadoMensal,
	        SimplificadoQuinzenal,
	        SimplificadoQuinzenal,
	        SimplificadoSemanal
        }

2) Criar a classe abstrata Extrato, contendo o método abstrato Emitir e o método fábrica CriarExtrato.

        public abstract class Extrato
        {
	        public abstract void Emitir();

            public static Extrato CriarExtrato(Extrato tipo)
	        {
		        throw new NotImplementedException();
	        }
        }

3) Criar a classe concreta ExtratoCompleto, implementando a classe abstrata Extrato e a sobrescrita do método Emitir.

        public class ExtratoCompleto : Extrato
        {
	        public override void Emitir()
	        {
		        // Código para emissão do extrato completo
		        throw new NotImplementedException();
	        }
        }

4) Fazer o mesmo do passo anterior para os outros tipos de extratos.

5)  Implementar no método fábrica CriarExtrato o retorno para cada tipo de extrato.

        public static Extrato CriarExtrato(Extrato tipo)
        {
	        switch (tipo)
	        {
		        case Extratos.Completo:
			        return new ExtratoCompleto();
		        case Extratos.SimplificadoMensal:
			        return new ExtratoSimplificadoMensal();
		        case Extratos.SimplificadoQuinzenal:
			        return new ExtratoSimplificadoQuinzenal();
		        case Extratos.SimplificadoSemanal:
			        return new ExtratoSimplificadoSemanal();
		        default:
			        throw new TipoExtratoNaoEncontradoException();
	        }
        }

6) No método EmitirExtrato, remover todo o código e fazer a chamada do metodo Emitir a partir do CriarExtrato, fazendo uso do polimorfismo (“Substituir Comando Condicional por Polimorfismo”).

        public void EmitirExtrato(Extratos tipo)
        {
	        Extrato.CriarExtrato(tipo).Emitir();
        }

