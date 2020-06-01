using System;

namespace Sky.Treinamento.Refatoracao.Exercicios
{
    /// <summary>
    /// Problema: A classe está perdendo coesão, fazendo um trabalho que poderia ser feito por duas ou mais classes. 
    /// 
    /// Solução: Com base no método "Extrair Classe", criar uma nova classe e mova os campos e métodos pertinentes.
    /// </summary>

    public class Security
    {
        private const string RulesPath = "/usr/rules.xml";

        public Security()
        {
            LoadRules(RulesPath);
        }

        private void LoadRules(string rulesPath)
        {
            // código que carrega as regras
            throw new NotImplementedException();
        }

        public bool VerifyUser() 
        {
            // código que valida o usuário
            return true;
        }
    }    
}
