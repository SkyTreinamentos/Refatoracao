using System.Collections.Generic;
using System;

namespace Sky.Treinamento.Refatoracao.Exercicios
{
    /// <summary>
    /// Problema: Os trechos de código com comentários poderiam ser agrupados para tornar a lógica mais fácil de ser entendida. 
    /// 
    /// Solução: Utilizando o método "Extrair para método", transforme esses fragmentos em métodos, cujos nome expliquem o propósito do mesmo.
    /// </summary>
    public class Exercicio02
    {
        private readonly string nomeDoCliente;
        private readonly double saldoTotal;

        public void ExibirExtrato(Periodo periodo)
        {
            // imprimir cabeçalho
	        Console.WriteLine("--------------");
	        Console.WriteLine("Extrato Banco do Brasil");
	        Console.WriteLine("--------------");
            // imprimir detalhes
	        Console.WriteLine("NOME: " + nomeDoCliente);
	        foreach(var lancamento in periodo.Lancamentos)
	        {
		        Console.WriteLine(lancamento);
	        }
	        Console.WriteLine("SALDO: " + saldoTotal);
            // imprimir rodapé
	        Console.WriteLine("--------------");
	        Console.WriteLine(ObterDataEHoraAtual());
        }

        private string ObterDataEHoraAtual()
        {
            return DateTime.Now.ToString("yyyyMMddHHmm");
        }
    }    

    public struct Periodo
    {
        public IEnumerable<string> Lancamentos { get; set; }
    }
}
