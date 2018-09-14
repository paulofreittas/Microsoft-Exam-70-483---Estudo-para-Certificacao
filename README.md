# Microsoft Exam 70-483 - Programação em C#

Código desenvolvido em proposito das exigências cobradas no exame de certificação microsoft 70-483 : Programação em C#.

## Gerenciar fluxo de programa (25 - 30%)

- Implementar processamento multithreading e assíncrono

Usar a biblioteca Task Parallel, incluindo o Parallel.For method, PLINQ, Tasks; gerar threads usando ThreadPool; desbloquear a IU; usar palavras-chave async e await; gerenciar dados usando coleções simultâneas.

- Gerenciar multithreading

Sincronizar recursos; implementar bloqueio; cancelar uma tarefa de execução longa; implementar métodos thread-safe para manipular condições de corrida.

- Implementar fluxo de programa

Iterar em itens de coleção e de matriz; programar decisões usando instruções switch, se/então e operadores; avaliar expressões.

- Criar e implementar eventos e retornos de chamada

Criar manipuladores de eventos; assinar e cancelar assinatura de eventos; usar tipos delegados integrados para criar eventos; criar delegados; expressões lambda; métodos anônimos.

- Implementar manipulação de exceções

Manipular tipos de exceções, incluindo exceções SQL, exceções de rede, exceções de comunicação, exceções de tempo limite de rede; usar declarações de captura; usar uma classe base de uma exceção; implementar blocos try-catch-finally; lançar exceções; relançar uma exceção; criar exceções personalizadas; manipular exceções internas; manipular exceções agregadas.

## Criar e usar tipos (25 - 30%)

- Criar tipos

Criar tipos de valor, incluindo estruturas e num; criar tipos de referência, tipos genéricos, construtores, variáveis ​​estáticas, métodos, classes, métodos de extensão, parâmetros opcionais e nomeados e propriedades indexadas; criar métodos sobrecarregados e substituídos.

- Consumir tipos

Box ou unbox para converter entre tipos de valor; tipos elenco; converter tipos; lidar com tipos dinâmicos; garantir a interoperabilidade com código que acesse APIs COM.

- Aplicar encapsulamento

Aplicar encapsulamento usando propriedades; forçar encapsulamento usando assessores, incluindo público, privado, protegido e interno; forçar encapsulamento usando implementação explícita de interface.

- Criar e implementar uma hierarquia de classe

Projetar e implementar uma interface; herdar de uma classe base; criar e implementar classes com base nas interfaces IComparable, IEnumerable, IDisposable e IUnknown.

- Localizar, executar e criar tipos em tempo de execução usando reflexão

Criar e aplicar atributos; ler atributos; gerar código em tempo de execução usando expressões CodeDom e lambda; usar tipos do namespace System.Reflection, incluindo Assembly, PropertyInfo, MethodInfo, Type.

- Gerenciar o ciclo de vida do objeto

Gerenciar recursos não gerenciados; implementar IDisposable, incluindo interação com finalização; gerenciar IDisposable usando a instrução Using; gerenciar finalização e coleta de lixo.

- Manipular cadeias de caracteres

Manipular cadeias de caracteres usando as classes StringBuilder, StringWriter e StringReader; pesquisar cadeias de caracteres; enumerar métodos de cadeias de caracteres; formatar cadeias de caracteres; usar interpolação de cadeia.

## Depurar aplicativos e implementar segurança (25 - 30%)

- Validar entrada de aplicativo

Validar dados JSON; escolher o tipo de coleta de dados adequado; gerenciar integridade de dados; avaliar uma expressão regular para validar o formato de entrada; usar funções internas para validar tipos e conteúdos.

- Realizar criptografia simétrica e assimétrica

Escolher um algoritmo de criptografia apropriado; gerenciar e criar certificados; implementar gerenciamento de chave; implementar o namespace System.Security; fazendo hash de dados; criptografar fluxos.

- Gerenciar montagens

Controlar versão de montagens; assinar montagens usando nomes fortes; implementar hospedagem lado a lado; colocar uma montagem no cache de montagens global; criar uma montagem WinMD.

- Depurar um aplicativo

Criar e gerenciar diretrizes de pré-processador; escolher um tipo de compilação apropriado; gerenciar arquivos e símbolos de banco de dados do programa (símbolos de depuração).

- Implementar diagnóstico em um aplicativo

Implementar log e rastreamento; criação de perfil de aplicativos; criar e monitor contadores de desempenho; escrever para o log de eventos.

## Implementar acesso aos dados (25 - 30%)

- Realizar operações de E/S

Ler e escrever arquivos e fluxos; ler e escrever a partir da rede usando classes no namespace System.Net; implementar operações de E/S assíncronas.

- Dados de consumo

Recuperar dados de um banco de dados; atualizar dados em um banco de dados; consumir dados JSON e XML; recuperar dados usando serviços Web.

- Consultar e manipular dados e objetos usando LINQ

Consultar dados usando operadores, incluindo projetar, juntar, agrupar, obter, ignorar, agregar; criar consultas LINQ baseadas em método; consultar dados usando sintaxe de compreensão de consulta; selecionar dados usando tipos anônimos; forçar a execução de uma consulta; ler, filtrar, criar e modificar as estruturas de dados de usando LINQ to XML.

- Serializar e de-serializar dados

Serializar e de-serializar dados usando serialização binária, serialização personalizada, Serializador XML, Serializador JSON e Serializador de Contrato de Dados.

- Armazenar dados e recuperar dados de coleções

Armazenar e recuperar dados usando dicionários, matrizes, listas, conjuntos e filas; escolher um tipo de coleção; inicializar uma coleção; adicionar e remover itens de uma coleção; usar coleções tipificadas vs. coleções não tipificadas; implementar coleções personalizadas; implementar interfaces de coleções.