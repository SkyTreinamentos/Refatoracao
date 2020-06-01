# **Exercício 10**
## Problema:
A classe está perdendo coesão, fazendo um trabalho que poderia ser feito por duas ou mais classes.

## Solução:
Com base no método "Extrair Classe", criar uma nova classe e mova os campos e métodos pertinentes.

## Passos a serem executados:
1) Criar uma nova classe específico para controle do carregamento de regras (“Extrair Classe”).

        public static class SecurityRulesLoader
        {
	        private const string RulesPath = "/usr/rules.xml";

	        public static void LoadRules()
	        {
    		    // código que carregas as regras
	    	    throw new NotImplementedException();
	        }
        }

2) Na classe Security, substituir no construtor o método LoadRules pelo da nova classe, remover da classe Security constante e função LoadRules.

        public class Security
        {
            public Security()
            {
                SecurityRulesLoader.LoadRules();
            }        

            public bool VerifyUser() 
            {
                // código que valida o usuário
                return true;
            }
        } 