# 🐷 Simple Pig Latin App

Uma aplicação de console robusta desenvolvida em **C#** que traduz palavras e frases para o dialeto "Pig Latin". O projeto foca em manipulação de strings, expressões regulares (Regex) e programação defensiva.

![Demonstração do App](./img/presentation.gif)

## ✨ Funcionalidades

* **Tradução Inteligente:** Identifica automaticamente se a palavra deve receber o sufixo `way` (iniciada por vogal) ou `ay` (iniciada por consoante).
* **Preservação de Capitalização:** Se a palavra original começar com letra maiúscula, o resultado traduzido também respeitará essa formatação.
* **Suporte a Acentos:** Utiliza Regex customizado para suportar caracteres da língua portuguesa (`á`, `é`, `õ`, `ç`, etc.).
* **Filtro de Caracteres:** Limpa pontuações e símbolos, processando apenas o texto puro.
* **Programação Defensiva:** Inclui tratamento de exceções (`try-catch`) e validações de nulidade para evitar falhas durante a execução.

## 🛠️ Tecnologias Utilizadas

* C# (.NET 8.0+)
* System.Text.RegularExpressions (Regex)
* LINQ (System.Linq)

## 🚀 Como Executar

1. Certifique-se de ter o SDK do .NET instalado.
2. Clone o repositório.
3. No terminal, execute:
   ```bash
   dotnet run
4. Digite as palavras desejadas ou **sair** para encerrar.

---
### 🤝 Contato

Desenvolvido por [![LinkedIn](https://img.shields.io/badge/LinkedIn-0077B5?style=flat-square&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/rodrigolca) **Rodrigo Lopes**