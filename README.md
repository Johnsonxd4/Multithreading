# Trabalhando com Multi Threading em C#

## Porque?

Trabalhar com Threads é necessário para que programas/processos possam ser executados em paralelo, sem que processos que demandem muito tempo e processamento, congelem ou interfiram em outros programas/processos.

Trabalhar com Multithreading também tem a vantagem de que pode se utilizar de varios cores de processadores, ajudando na performance da aplicação.

## A Classe `Thread`

A classe Thread se encontra no namespace `System.Threading`.

Ela permite que você
> [Crie threads](https://github.com/Johnsonxd4/Multithreading/blob/43e0bd461edf94e66ea15afaae6930338ce5b356/ExemploThreading/Program.cs#L8).

> Gerencie suas prioridades.

> Consulte o seu estado.

Esta classe não é recomendada para que seja usada dentro de suas aplicações, exceto em algumas exceções. Utilizando esta classe, você tem controle sobre todas as opções de configuração.

*Synchronization* (sincronização) é o mecanismo que garante que duas threads não execute o mesmo método ou modifiquem a mesma variável/propriedade ao mesmo tempo. Um exemplo de classe que implementa este mecanismo é a `Console`. Se duas threads tentarem invocar, por exemplo, o método `Console.WriteLine("")`, a segunda thread irá aguardar até que a primeira thread termine a utilzação do método.

### `Thread.Join()`

O método [`Thread.Join()`](https://github.com/Johnsonxd4/Multithreading/blob/43e0bd461edf94e66ea15afaae6930338ce5b356/ExemploThreading/Program.cs#L16) é utilizado para que a thread principal aguarde a finalização da thread paralela, para que o [código abaixo](https://github.com/Johnsonxd4/Multithreading/blob/43e0bd461edf94e66ea15afaae6930338ce5b356/ExemploThreading/Program.cs#L18) do método em questão seja executado somente quando a thread paralela seja finalizada.

### [`Thread.Sleep(0)`](https://github.com/Johnsonxd4/Multithreading/blob/43e0bd461edf94e66ea15afaae6930338ce5b356/ExemploThreading/Program.cs#L24)

Este método sinaliza para o sistema operacional que a thread finalizou seu processamento. O sistema operacional executa outras thread no intervalo de tempo informado no método, em vez de somente esperar o tempo informado.

### Threads parametrizadas

O Construtor da classe `Thread` tem uma sobrecarga que permite criar Threads parametrizadas. Este Construtor aceita como parametro uma instância do delegate [`ParameterizedThreadStart`](https://github.com/Johnsonxd4/Multithreading/blob/4d9d10042420e6abebf43c75c703a733ac78d588/ExemploThreading/Program.cs#L21). O parâmetro é passado para a thread quando ela é iniciada pelo método [`Thread.Start(object obj)`](https://github.com/Johnsonxd4/Multithreading/blob/4d9d10042420e6abebf43c75c703a733ac78d588/ExemploThreading/Program.cs#L22). 

### Atributo `ThreadStatic`

Quando anotamos um atributo ou  propriedade estática com `ThreadStatic`, este se torna um campo estático por thread. Cada thread possui sua própria cópia do campo.

### Trabalhando com `ThreadPool`

Quando trabalhamos com a classe Thread, uma thread é criada, e a thread morre quando finaliza sua execução. Porém a criação destas threads custa algum tempo e recursos.
A classe `ThreadPool` foi criada para reutilizar estas threads, de uma forma parecida com o pool de conexões de banco de dados. Em vez de deixar simplesmente a thread morrer no fim da sua execução, ela é enviada novamente para o pool para ser reutilizada quando uma nova requisição entrar.
Utilizando o método [`ThreadPool.QueueUserWorkItem`](https://github.com/Johnsonxd4/Multithreading/blob/8a526e27f2564156e0c8fae6f686c23510f32079/ExemploThreading/Program.cs#L34), você adiciona um  trabalho à fila que será executada por uma thread disponivel no pool de threads.