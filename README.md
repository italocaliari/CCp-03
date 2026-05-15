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

1. **Menu Principal:** ![Menu]
<img width="1105" height="621" alt="Captura de tela 2026-05-14 212629" src="https://github.com/user-attachments/assets/83ca956d-7f2c-4b73-817e-759b83572e43" />

2. **Registro e Listagem:** ![Listagem]
<img width="1105" height="618" alt="Captura de tela 2026-05-14 212709" src="https://github.com/user-attachments/assets/0edf83ac-6e37-497e-99cf-a1549bf7842e" />
<img width="1099" height="615" alt="Captura de tela 2026-05-14 212756" src="https://github.com/user-attachments/assets/8517a78d-1f4a-4aa6-88f6-58f77bb85d52" />
<img width="1102" height="619" alt="Captura de tela 2026-05-14 212811" src="https://github.com/user-attachments/assets/2d41ee6d-0edf-485f-9e6c-ab58c3c7f908" />

3. **Cálculo de Totais:** ![Totais]
<img width="1105" height="620" alt="Captura de tela 2026-05-14 212821" src="https://github.com/user-attachments/assets/8c90fb27-f4f1-4c79-ba20-e168cdedae16" />
<img width="1106" height="620" alt="Captura de tela 2026-05-14 212831" src="https://github.com/user-attachments/assets/4aaf0919-b6bc-4762-af78-0fb95cfcf105" />


## 🛠️ Como rodar o projeto
1. Clone o repositório.
2. Certifique-se de ter o .NET SDK instalado.
3. Execute o comando `dotnet run` na pasta do projeto.
