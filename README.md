# Lista de Exercícios — Algoritmos e Estruturas de Dados - Estrutura de dados Flexíveis

Este repositório contém as soluções para a lista de exercícios da disciplina **Algoritmos e Estruturas de Dados - Estrutura de dados Flexíveis** — PUC Minas.

As respostas estão em padrão simplificado devido a entrega da lista ser por correção automática no Verde (sistema de correção da PUC)

**Implicações**
> Todas as classes estão criadas no program.cs devido a formatação de correção (o Main também)
> 
> Todas as escritas do Console estão resumidas

Abaixo, um resumo dos exercícios implementados:

PDF da lista: [Lista5_TADsFlexiveis.pdf](https://github.com/user-attachments/files/20017525/Lista5_TADsFlexiveis.pdf)

---

### ✅ 1️⃣ Pilha Flexível — Validação de Parênteses e Colchetes

Verifica se uma sequência de parênteses e colchetes está corretamente balanceada usando pilha flexível.

**Exemplos:**
- `(()[()])` → correta  
- `([)]` → errada

---

### ✅ 2️⃣ Pilha Flexível — Conversão Decimal para Octal

Converte um número decimal para octal utilizando pilha flexível.

**Exemplos:**
- `137` → `211`  
- `3821` → `7355`

---

### ✅ 3️⃣ Fila Flexível — Fila de Impressão

Simulação de uma fila de impressão usando fila flexível.

**Exemplos de operações:**
- Adicionar: `1 → prova1.pdf 1`  
- Listar: `3 → prova1.pdf 1 / prova2.pdf 3`  
- Remover: `2 → prova1.pdf`

---

### ✅ 4️⃣ Fila Flexível — Bolsas Acme

Simulação de fila de candidatos para bolsas, separando aprovados e suplentes.

**Exemplos de operações:**
- Adicionar aprovado: `1 → Maria`  
- Adicionar suplente: `2 → Paulo`  
- Listar aprovados: `5 → Maria / Camila / Laura`  
- Verificar aprovado: `7 → Camila → S`

---

### ✅ 5️⃣ Lista Simples Flexível — Tempos de Maratona

Gerenciamento de tempos de maratona com lista simples flexível.

**Exemplos de operações:**
- Inserir início/fim: `1 → 2`  
- Inserir em posição: `3 → 4 na posição 1`  
- Listar: `9 → 3 / 4 / 2 / 1`  
- Contar ocorrências: `8 → 5 → 0`

---

### ✅ 6️⃣ Lista Simples Flexível — Sites

Gerenciamento de sites favoritos.

**Exemplos de operações:**
- Adicionar início: `1 → google https://www.google.com`  
- Adicionar fim: `2 → canvas https://canvas.pucminas.br`  
- Listar: `7 → google / canvas`  
- Buscar site: `8 → google → https://www.google.com`

---

### ✅ 7️⃣ Lista Dupla Flexível — Músicas

Gerenciamento de uma lista de músicas com lista dupla flexível.

**Exemplos de operações:**
- Adicionar início/fim: `1 → Catedral` / `2 → Tempo perdido`  
- Adicionar posição: `3 → A cruz e a espada na posição 1`  
- Listar início → fim: `8 → Pais e filhos / Tempo perdido / Catedral`  
- Listar fim → início: `9 → A carta / Catedral / A cruz e a espada`

