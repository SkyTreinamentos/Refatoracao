# **Exercício 23**
## Problema:
O método **ConverterVideo** está lançando uma exceção customizada para tratar um cenário específico (objeto == null).

## Solução:
Conforme o método/orientação **"Prefira o Uso de Exceções Padrão do Framework"**, substitua a exceção customizada pela padrão do framework.

## Passos a serem executados:
1) Substituir o lançamento da exceção VideoInvalidoException pela ArgumentNullException, passando como parâmetro nessa exceção o nome do argumento nulo.

        public void ConverterVideo(Video video)
        {
            if (video == null)
                throw new ArgumentNullException(nameof(video));
            // código da conversão do vídeo
        }
