# Trabalhando com Multi Threading em C#

## Porque?

Trabalhar com Threads é necessário para que programas/processos possam ser executados em paralelo, sem que processos que demandem muito tempo e processamento, congelem ou interfiram outros programas/processos.

Trabalhar com Multithreading também tem a vantagem de que pode se utilizar de varios cores de processadores, ajudando na performance da aplicação.

## A Classe `Thread`

A classe Thread se encontra no namespace `System.Threading`.

Ela permite que você
> Crie threads.

> Gerencie suas prioridades.

> Consulte o seu estado.

Esta classe não é recomendada para que seja usada dentro de suas aplicações, exceto em algumas exceções. Utilizando esta classe, você tem controle sobre todas as opções de configuração.

*Synchronization* (sincronização) é o mecanismo que garante que duas threads não execute o mesmo método ou modifiquem a mesma variável/propriedade ao mesmo tempo. Um exemplo de classe que implementa este mecanismo é a `Console`. Se duas threads tentarem invocar, por exemplo, o método `Console.WriteLine("")`, a segunda thread irá aguardar até que a primeira thread termine a utilzação do método.

### O método `Thread.Join()`

O método `Thread.Join()` é utilizado para que a thread principal aguarde a finalização da thread paralela, para que o código abaixo do método em questão seja executado somente quando a thread paralela seja finalizada.