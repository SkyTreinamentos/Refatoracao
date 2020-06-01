# **Exercício 14**
## Problema:
Método na classe Bibliteca retorna uma coleção, atribuindo apenas uma referência de uma lista, e trabalhando com o método nativo Add da classe List, sendo necessário manipular o objeto para adicionar e remover livros.

## Solução:
Com base no método "Encapsular Coleção", faça-o retornar uma visão apenas de leitura e fornecer métodos de adição e remoção.

## Passos a serem executados:
1) Criar na classe Biblioteca métodos para Adicionar e Remover itens da lista privada (“Encapsular Coleção”).

        public class Biblioteca
        {
            private readonly List<Livro> livros;

            public Biblioteca(List<Livro> livros)
            {
                this.livros = livros;
            }

            public void AdicionarLivro(Livro livro)
            {
	            livros.Add(livro);
            }

            public void RemoverLivro(Livro livro)
            {
	            livros.Remove(livro);
            }
        }

2) Substituir no método InserirLivros a utilização do método Add da class List pelo método AdicionarLivro da classe Biblioteca e remover a variável temporária da lista, bem como a atribuição da lista de livros.

        public void InserirLivros()
        {
	        Biblioteca biblioteca = new Biblioteca();

	        biblioteca.AdicionarLivro(new Livro("Refactoring"));
	        biblioteca.AdicionarLivro(new Livro("Clean Code"));
	        biblioteca.AdicionarLivro(new Livro("Effective C#"));
	        biblioteca.AdicionarLivro(new Livro("Design Patterns"));
        }   