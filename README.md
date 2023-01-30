# Trabalho Intermediário de Algoritmos e Técnicas de Programação

Trabalho de Sistemas de Informação (PUC MINAS) em dupla realizado por Otávio Rocha e Luiz Fernando Ribeiro 

## Criar um algoritmo que simule o funcionamento de uma caixa eletrônico

- Deve possuir 3 tipos de conta:
1. Conta corrente
2. Conta corrente com cheque especial
3. Conta poupança

- Deve conter um menu com 6 operações:
1. Consulta de saldo
2. Saque
3. Depósito
4. Pagamento de contas (água, luz, telefone...)
5. Transferência
6. Sair

- Após o intervalo de 5 operações cobrar juros do cheque especial e atualizar os rendimentos da conta poupança (taxa de juros definida pelo usuário).

Algoritmo realizado utilizando C# para o display dos dados no console

- Uso da estrutura do-while para mostrar o menu em sequência;
- Resolvido: conflito com o saldo real do cheque especial não mostrando o valor correto resolvido com a criação de uma terceira variável para controlar o valor de saldo + limite;
- Verificação de saldo positivo das contas antes de realizar cada operação;
- Uso de condicional IF para averiguar a opção selecionada pelo usuário (substituição pelo switch);





