# Sistema de Registro de Operações Financeiras - C#

Este projeto é uma Console Application desenvolvida para a disciplina [Nome da Disciplina], com o objetivo de simular o registro de compra e venda de ativos financeiros.

## 👥 Integrantes
* **italo caliari silva** - RM: 554758


## 🚀 Tecnologias e Critérios Atendidos
O projeto foi estruturado seguindo os padrões solicitados:
1. **Estruturas de Controle:** Uso de `switch`, `do/while`, `foreach` e `if/else`.
2. **POO Avançada:** Implementação de classe abstrata (`Operation`), herança (`BuyOperation`, `SellOperation`) e polimorfismo (`GetDetails`).
3. **Membros Estáticos:** Geração automática de IDs únicos via `static int _nextId`.
4. **Tratamento de Exceções:** Uso de blocos `try-catch` para evitar crash por entradas inválidas.
5. **Partial Class:** A classe `Operation` está dividida em arquivos para melhor organização.
6. **Armazenamento:** Uso de `List<Operation>` para persistência em memória.

## 📸 Evidências de Teste
*(DICA: Tire prints do seu console funcionando e suba as imagens para a pasta do projeto no GitHub. Depois, substitua os links abaixo)*

1. **Menu Principal:** ![Menu](link-da-imagem)
2. **Registro e Listagem:** ![Listagem](link-da-imagem)
3. **Cálculo de Totais:** ![Totais](link-da-imagem)

## 🛠️ Como rodar o projeto
1. Clone o repositório.
2. Certifique-se de ter o .NET SDK instalado.
3. Execute o comando `dotnet run` na pasta do projeto.
