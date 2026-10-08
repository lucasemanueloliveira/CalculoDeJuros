# Cálculo de Juros por Atraso

Solução desenvolvida em **C#/.NET** como parte de um desafio técnico proposto durante um processo seletivo.

## Sobre o projeto

O desafio consiste em desenvolver um programa que, a partir de um **valor** e de uma **data de vencimento**, calcule o valor dos juros na data atual, considerando uma multa de **2,5% ao dia**.

## Funcionamento

A aplicação recebe:

- O valor da dívida.
- A data de vencimento.

Em seguida:

1. Obtém a data atual.
2. Calcula a quantidade de dias em atraso.
3. Aplica a taxa de 2,5% ao dia.
4. Calcula o valor dos juros.
5. Apresenta o valor total atualizado.

## Regra de cálculo

O valor dos juros é calculado considerando 2,5% do valor original para cada dia de atraso.

```text
Juros = Valor × 0,025 × Dias em atraso
```

O valor total é:

```text
Valor total = Valor original + Juros
```

## Exemplo

Considerando:

```text
Valor: R$ 100,00
Data de vencimento: 25/06/2026
Data atual: 07/10/2026
Dias em atraso: 104
```

O cálculo será:

```text
Juros = 100 × 0,025 × 104
Juros = R$ 260,00
```

Resultado:

```text
Valor original: R$ 100,00
Juros: R$ 260,00
Valor total: R$ 360,00
```

## Tecnologias utilizadas

- C#
- .NET
- System.Globalization
- DateTime
- Programação Orientada a Objetos
- Git
- GitHub

## Como executar

1. Clone o repositório.
2. Abra o projeto no Visual Studio.
3. Compile a aplicação.
4. Execute o projeto.
5. Informe o valor da dívida.
6. Informe a data de vencimento no formato `ddMMyyyy`.

## Objetivo

Este projeto foi desenvolvido para atender ao requisito apresentado no desafio técnico, demonstrando o uso de **C#/.NET**, manipulação de datas, cálculo de períodos e aplicação de regras de negócio.
