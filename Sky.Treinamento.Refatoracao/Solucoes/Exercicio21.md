# **Exercício 21**
## Problema:
Possui um bloco catch vazio, sem retorno. Caso ocorra algum erro na operação, essa será abortada e não executará por completo, porém não exposto o problema para o usuário final.

## Solução:
A partir do método “Não ignore exceções”, avaliar se faz sentido continuar utilizando uma exceção verificada. Caso sim, escolher uma forma de retorno ou registro da exceção, como adicionar em um log.

## Passos a serem executados:
1) Registrar a exception em uma log de erros.

        public void ExecutarMetodo()
        {
            try
            {
                // código que lança exceção
            }
            catch (ArgumentOutOfRangeException exc)
            {
                Logger.RegistrarErro(exc);
            }
        }
