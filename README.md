## Calculadora

Este é um pequeno projeto de calculadora em C# desenvolvido usando a metodologia Test-Driven Development (TDD).

O objetivo do projeto é demonstrar o conhecimento do desenvolvedor na metodologia TDD.

### Como usar

Para usar a calculadora, basta instanciar a classe `Calculadora` e chamar os métodos `Somar()`, `Subtrair()`, `Multiplicar()` ou `Dividir()`, passando os valores desejados como parâmetros.

Por exemplo, para somar 1 e 2, você pode fazer o seguinte:

```c#
var calculadora = new Calculadora("21/10/2023");

int resultado = calculadora.Somar(1, 2);

Console.WriteLine(resultado); // 3
```

### Histórico

A calculadora também possui um histórico de operações realizadas. Para obter o histórico, basta chamar o método `Historico()`.

O histórico é uma lista de strings, cada uma contendo a operação realizada e a data em que ela foi realizada.

Por exemplo, para obter o histórico das últimas 3 operações realizadas, você pode fazer o seguinte:

```c#
var calculadora = new Calculadora("21/10/2023");

calculadora.Somar(1, 2);
calculadora.Subtrair(3, 4);
calculadora.Multiplicar(5, 6);

var lista = calculadora.Historico();

foreach (var operacao in lista)
{
    Console.WriteLine(operacao);
}
```

### TDD

Este projeto foi desenvolvido usando a metodologia TDD. TDD é um processo de desenvolvimento de software que usa testes unitários para guiar o desenvolvimento do código.

Para usar TDD, você deve primeiro escrever um teste unitário para a funcionalidade que deseja implementar. Em seguida, você deve implementar o código mínimo necessário para que o teste passe. Uma vez que o teste passe, você pode refatorar o código conforme necessário.

Este processo é repetido até que toda a funcionalidade desejada esteja implementada e todos os testes unitários estejam passando.

### Conclusão

Este projeto é um exemplo de como usar TDD para desenvolver um pequeno aplicativo em C#.
