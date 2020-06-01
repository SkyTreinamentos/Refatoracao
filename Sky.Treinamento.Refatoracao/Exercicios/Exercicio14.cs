using System.Collections.Generic;

namespace Sky.Treinamento.Refatoracao.Exercicios
{
    /// <summary>
    /// Problema: Método na classe Bibliteca retorna uma coleção, atribuindo apenas uma referência de uma lista, 
    /// e trabalhando com o método nativo Add da classe List, sendo necessário manipular o objeto para adicionar 
    /// e remover livros. 
    /// 
    /// Solução: Com base no método "Encapsular Coleção", faça-o retornar uma visão apenas de leitura e fornecer 
    /// métodos de adição e remoção.
    /// </summary>
    public class Exercicio14
    {
        public void InserirLivros()
        {
            Biblioteca biblioteca = new Biblioteca();

            List<Livro> livros = new List<Livro>();

            livros.Add(new Livro("Refactoring"));
            livros.Add(new Livro("Clean Code"));
            livros.Add(new Livro("Effective C#"));
            livros.Add(new Livro("Design Patterns"));

            biblioteca.Livros = livros;
        }
    }

    public class Biblioteca
    {
        private List<Livro> livros;

        public List<Livro> Livros 
        { 
            get
            {
                return livros;
            }
            set
            {
                livros = value;
            }
        }
    }    

    public class Livro
    {
        public string Nome { get; set; }

        public Livro(string nome)
        {
            Nome = nome;
        }
    }
}
