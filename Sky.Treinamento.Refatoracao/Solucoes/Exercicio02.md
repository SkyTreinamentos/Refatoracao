# **Exercício 02**
## Problema:
Os trechos de código com comentários poderiam ser agrupados para tornar a lógica mais fácil de ser entendida.

## Solução:
Utilizando o método **"Extrair para método"**, transforme esses fragmentos em métodos, cujos nome expliquem o propósito do mesmo.

## Passos a serem executados:
1) Extrair o trecho do comentário "imprimir cabeçalho" para um método.

        private void ImprimirCabecalho()
        {
            Console.WriteLine("--------------");
	        Console.WriteLine("Extrato Banco do Brasil");
	        Console.WriteLine("--------------");
        }

2) Extrair o trecho do comentário "imprimir rodapé" para um método.

        private void ImprimirDetalhes(Periodo periodo)
        {
            Console.WriteLine("NOME: " + nomeDoCliente);
	        foreach(var lancamento in periodo.Lancamentos)
	        {
		        Console.WriteLine(lancamento);
	        }
	        Console.WriteLine("SALDO: " + saldoTotal);
        }

3) Extrair o trecho do comentário "imprimir detalhes" para um método.

        private void ImprimirRodape()
        {
            Console.WriteLine("--------------");
	        Console.WriteLine(ObterDataEHoraAtual());
        }

4) Substituir os trechos do método ExibirExtrato pelos métodos criados.

        public void ExibirExtrato(Periodo periodo)
        {
            // imprimir cabeçalho
	        ImprimirCabecalho();
            // imprimir detalhes
	        ImprimirDetalhes(periodo);
            // imprimir rodapé
	        ImprimirRodape();
        }

5) Como os comentários ficaram redundantes, remove-los.

        public void ExibirExtrato(Periodo periodo)
        {
	        ImprimirCabecalho();
	        ImprimirDetalhes(periodo);
	        ImprimirRodape();
        }
