# **Exercício 13**
## Problema:
As subclasses possuem 2 métodos diferentes que executem passos semelhantes na mesma ordem, mas esses passos são diferentes. 

## Solução:
Com base no método "Criar um Template Method", eliminar a duplicação de métodos criando uma classe abstrata contendo os métodos semelhantes e criando métodos abstratos para os métodos que diferem. Nas classes filhas, implementar sobrescrita dos métodos abstratos

## Passos a serem executados:
1) Criar classe abstrata MaquinaDeBebidaQuente.

        public abstract class MaquinaDeBebidaQuente
        { 
	        public void PrepararBebida()
	        {
		        FerverAgua();
		        FazerInfusao();
		        ColocarNaXicara();
		        Condimentar();
	        }

	        public void FerverAgua()
	        {
		        Console.WriteLine("Fervendo a água...");
	        }

	        public abstract void FazerInfusao();

            public void ColocarNaXicara()
	        {
		        Console.WriteLine("Colocando na xícara...");
	        }

            public abstract void Condimentar();
        }

2) Na classe MaquinaDeCafe, definir implementação de classe abstrata MaquinaDeBebidaQuente. Sobrescrever os métodos FazerInfusao e Condimentar e mover para esses o código contido nos métodos PassarCafe e ColocarAcucar, respectivamente. Em seguida, remover os comandos PrepararCafe, FerverAgua, PassarCafe, ColocarNaXicara e ColocarAcucar.

        public class MaquinaDeCafe : MaquinaDeBebidaQuente
        {

	        public override void FazerInfusao()
	        {
		        Console.WriteLine("Passando o café...");
	        }

	        public override void Condimentar()
	        {
		        Console.WriteLine("Colocando açúcar...");
	        }	
        }

3) Nas classe MaquinaDeCha, realizar o mesmo procedimento descrito no passo anterior.

        public class MaquinaDeCha : MaquinaDeBebidaQuente
        {

	        public override void FazerInfusao()
	        {
		        Console.WriteLine("Mergulhando o chá...");
	        }

	        public override void Condimentar()
	        {
		        Console.WriteLine("Colocando limão...");
	        }	
        }
