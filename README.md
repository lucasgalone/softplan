## 💻 Sobre o projeto

SoftTeste - É um projeto onde se tem uma visão de como realizar integração entre APIs, configuração de swagger e configuração de arquivos como dockerfile
e docker-compose.

Os usuários terão acesso ao swagger pelo link http://localhost:7000/index.html, onde poderão:
- realizar o calculo de juros composto recebendo dois parametros o valor como primeiro parâmetro e o tempo como segundo parâmetro.
- Obter o link do repository onde se encontra o codigo fonte do projeto.

A fórmula abaixo representa a formula utilizada na execução do cálculo.

```csharp
valor * (1 + juros) ^ Tempo;
```

Definições propriedades utilizadas na formula de cálculo.

| Nome   | Descrição                                                                            |
|--------|--------------------------------------------------------------------------------------|
| Valor  | Valor é um decimal recebido como parâmetro                                           |
| Juros  | Juros é um valor decimal recebido a partir de uma integração com outra API           |
| Tempo  | Tempo é um valor inteiro que representa meses                                        |

## 🛠 Tecnologias

As seguintes ferramentas foram usadas na construção do projeto:

- [.Net core 3.1]
- [swagger]
- [docker]

## 🚀 Como executar o projeto

Para a execução do projeto basta a execução dos seguintes comandos na pasta raiz:
```csharp
docker-compose build
```
```csharp
docker-compose up -d
```

## 📝 Arquitetura
Foi construida uma solução onde se tem básicamente a separação de responsabilidades e utilizando a injeção de dependência para manter um desacoplamente da solução.
