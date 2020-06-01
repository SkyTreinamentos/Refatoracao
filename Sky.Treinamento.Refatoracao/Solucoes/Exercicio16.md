# **Exercício 16**
## Problema:
O mesmo fragmento de código aparece duplicado no then e no else de uma expressão condicional. 

## Solução:
Com base no método “Consolidar Fragmentos Condicionais Duplicados”, mova-os para fora da expressão.

## Passos a serem executados:
1) Mover o fragmento duplicado de código para fora da expressão condicional.

        public void SendRequest(object data)
        {
            if (data == null)
            {                
            }
            else
            {
                resource.Data = data;             
            }
            resource.Send();
        }

2) Mudar a expressão condicional, movendo o código do else para o then e removendo o else (“Decompor Condicional”).

        public void SendRequest(object data)
        {
            if (data != null)            
                resource.Data = data;            
            resource.Send();
        }
