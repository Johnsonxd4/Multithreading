# Trabalhando com Multi Threading em C#

## Porque?

Trabalhar com Threads é necessário para que programas/processos possam ser executados em paralelo, sem que processos que demandem muito tempo e processamento, congelem ou interfiram outros programas/processos.

Trabalhar com Multithreading também tem a vantagem de que pode se utilizar de varios cores de processadores, ajudando na performance da aplicação.

## A Classe `Thread`

A classe Thread se encontra no namespace `System.Threading`.

Ela permite que você
> Crie threads
> Gerencie suas prioridades,
> Consulte o seu estado.

Esta classe não é recomendada para que seja usada dentro de suas aplicações, exceto em algumas exceções. Utilizando esta classe, você tem controle sobre todas as opções de configuração.
