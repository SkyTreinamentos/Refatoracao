using System;

namespace Sky.Treinamento.Refatoracao.Exercicios
{
    /// <summary>
    /// Problema: As subclasses possuem 2 métodos diferentes que executem passos semelhantes na mesma ordem, mas esses 
    /// passos são diferentes. 
    /// 
    /// Solução: Com base no método "Criar um Template Method", eliminar a duplicação de métodos criando uma classe 
    /// abstrata contendo os métodos semelhantes e criando métodos abstratos para os métodos que diferem. Nas classes 
    /// filhas, implementar sobrescrita dos métodos abstratos.
    /// </summary>
    public class MaquinaDeCafe
    {
        public void FazerCafe()
        {
            FerverAgua();
            PassarCafe();
            ColocarNaXicara();
            ColocarAcucar();
        }

        private void FerverAgua()
        {
            Console.WriteLine("Fervendo a água...");
        }

        private void PassarCafe()
        {
            Console.WriteLine("Passando o café...");
        }

        private void ColocarNaXicara()
        {
            Console.WriteLine("Colocando na xícara...");
        }

        private void ColocarAcucar()
        {
            Console.WriteLine("Colocando açúcar...");
        }
    }

    public class MaquinaDeCha
    {
        public void FazerCha()
        {
            FerverAgua();
            MergulharCha();
            ColocarNaXicara();
            ColocarLimao();
        }

        private void FerverAgua()
        {
            Console.WriteLine("Fervendo a água...");
        }

        private void MergulharCha()
        {
            Console.WriteLine("Mergulhando o chá...");
        }

        private void ColocarNaXicara()
        {
            Console.WriteLine("Colocando na xícara...");
        }

        private void ColocarLimao()
        {
            Console.WriteLine("Colocando limão...");
        }
    }    
}
