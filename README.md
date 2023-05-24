# Sistema de Hospedagem Simples de Estudos

Este é um projeto simples em C# que simula um sistema de hospedagem. O objetivo é praticar a sintaxe da linguagem e demonstrar conceitos básicos de classes, objetos e métodos.

## Classe Pessoa

A classe `Pessoa` representa uma pessoa e possui os seguintes atributos:

- `Nome`: o nome da pessoa.
- `Sobrenome`: o sobrenome da pessoa.

Além disso, a classe possui os seguintes construtores:

- `Pessoa(string nome)`: cria uma instância da classe com o nome informado.
- `Pessoa(string nome, string sobrenome)`: cria uma instância da classe com o nome e sobrenome informados.

E os seguintes métodos:

- `NomeCompleto`: retorna o nome completo da pessoa.

## Classe Suite

A classe `Suite` representa uma suíte de hospedagem e possui os seguintes atributos:

- `TipoSuite`: o tipo da suíte.
- `Capacidade`: a capacidade da suíte (número máximo de hóspedes).
- `ValorDiaria`: o valor da diária da suíte.

A classe possui os seguintes construtores:

- `Suite()`: cria uma instância vazia da classe.
- `Suite(string tipoSuite, int capacidade, decimal valorDiaria)`: cria uma instância da classe com os valores informados.

## Classe Reserva

A classe `Reserva` representa uma reserva de hospedagem e possui os seguintes atributos:

- `Hospedes`: uma lista de objetos da classe `Pessoa` que representa os hóspedes da reserva.
- `Suite`: um objeto da classe `Suite` que representa a suíte reservada.
- `DiasReservados`: o número de dias da reserva.

A classe possui os seguintes construtores:

- `Reserva()`: cria uma instância vazia da classe.
- `Reserva(int diasReservados)`: cria uma instância da classe com o número de dias informado.

E os seguintes métodos:

- `CadastrarHospedes(List<Pessoa> hospedes)`: cadastra a lista de hóspedes na reserva, verificando se a capacidade da suíte é suficiente.
- `CadastrarSuite(Suite suite)`: cadastra a suíte na reserva.
- `ObterQuantidadeHospedes()`: retorna a quantidade de hóspedes da reserva.
- `CalcularValorDiaria()`: calcula o valor total da diária da reserva, considerando o número de dias e aplicando descontos, se aplicável.

## Programa Principal

O programa principal, na classe `Program`, cria instâncias de `Pessoa`, `Suite` e `Reserva`, e realiza o cadastro de hóspedes e suíte na reserva. Em seguida, exibe a quantidade de hóspedes e o valor total da diária.

## Executando o Programa

Para executar o programa, basta compilá-lo e executar o arquivo resultante. Os resultados serão exibidos no console.

Esse é um projeto simples de prática de sintaxe C#, ideal para entender e aplicar conceitos básicos de classes, objetos, construtores e métodos.

