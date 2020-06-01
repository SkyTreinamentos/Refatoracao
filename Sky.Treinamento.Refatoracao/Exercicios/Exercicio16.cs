using System;

namespace Sky.Treinamento.Refatoracao.Exercicios
{
    /// <summary>
    /// Problema: O mesmo fragmento de código aparece duplicado no then e no else de uma expressão condicional. 
    /// 
    /// Solução: Com base no método “Consolidar Fragmentos Condicionais Duplicados”, mova-os para fora da expressão.
    /// </summary>
    public class Exercicio16
    {
        private readonly Resource resource;

        public void SendRequest(object data)
        {
            if (data == null)
            {
                resource.Send();
            }
            else
            {
                resource.Data = data;
                resource.Send();
            }
        }
    }    

    public class Resource
    {
        public object Data { get; set; }

        public void Send()
        {
            throw new NotImplementedException();
        }
    }
}
