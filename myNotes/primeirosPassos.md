# Introdução ao C# (C Sharp)


## Código Base
Essa é a estrutura  base de um código feito em C#, o programa abaixo serve para imprimir a mensagem "Hello, World" na tela do console. A seguir vamos entender o que cada comando significa. 
```C#
using System;

namespace PrimeiroPrograma
{
    class HelloWorld
    {
        static void Main()
        {
            Console.WriteLine("Hello, World");
        }
    }
}
```

<br/> 

O programa **"Hello, World"** começa com uma diretiva *using* que faz referência ao namespace *System*. Namespaces fornecem um meio hierárquico de organizar bibliotecas e programas em C# (Basicamente esse *using* é a maneira do C# de importar bibliotecas). O namespace *System* contém a classe *Console* referenciada no programa e diversos outros namespaces, como por exemplo, entrada e saída de dados (I/O). Devido à diretiva *using*, que faz referência a um determinado namespace, o programa pode usar *Console.WriteLine* como um atalho para *System.Console.WriteLine*.
```C#
using System;
```

<br/> 

Em seguida é declarado o Namespace **"PrimeiroPrograma"**, Namespaces em C# são conjuntos de identificadores que tem como função agrupar funcionalidades comuns, assim também organizando-as.
```C#
namespace PrimeiroPrograma 
```

<br/>

A classe **"Hello"** declarada pelo programa tem um único membro, o método chamado Main. Uma classe é uma forma de definir um tipo de dado em uma linguagem orientada a objeto. Ela é formada por dados e comportamentos. Para definir os dados são utilizados os atributos, e para definir o comportamento são utilizados métodos.
```C#
class HelloWorld
```

<br/>

O método *Main* (método principal) é declarado com o modificador static. Embora os métodos de instância possam fazer referência a uma determinada instância de objeto delimitador usando a palavra-chave this, métodos estáticos operam sem referência a um objeto específico. Por convenção, um método estático denominado Main serve como ponto de entrada de um programa C#.
```C#
static void Main()
```

<br/>

A saída do programa é produzida pelo método *WriteLine* da classe *Console* no namespace *System*. Essa classe é fornecida pelas bibliotecas de classe padrão, que, por padrão, são referenciadas automaticamente pelo compilador.
```C#
Console.WriteLine("Hello, World");
```

<br/>

Outra maneira de imprimir uma mensagem na saída do programa é utilizando apenas o método *Write*. a diferença para o *WriteLine* é que ele imprime a mensagem mas não pula uma linha, já utilizando o *WriteLine* por padrão ele deixa uma linha em branco.
```C#
Console.Write("Hello, World");
```

<br/>

## Comentários
Existem duas maneiras de fazer comentários no seu código, a primeira é utilizando o "//" para fazer um comentário em uma única linha, a segunda maneira é utilizando "/* */" para comentários multilinhas.
```C#
// Este é um comentário de uma única linha

/*
    Este é um comentário
    de várias
    linhas
*/
```

<br/>
<br/>

# Assuntos importantes abordados nesse arquivo:
* ### Namespaces
* ### Estrutura de um código C#
* ### Comando para imprimir uma mensagem na saída do console
* ### Como fazer comentários no código
