using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Trabalho Realizado Por Otávio Rocha e Luiz Fernando Ribeiro.

            string destinatario;
            double conta_corrente, poupanca, conta_cheque, limite_cheque, limite_cheque_update, saldo_conta_cheque, saque, deposito, agua, luz, telefone, conta_total, valor_outro, poupanca_tax = 0.005, poupanca_rend, transf_value, juros_especial, especial_valor = 0, saldo_especial;
            int n_operacao, i, outro, count = 0;
            int numero_conta; //1: conta corrente   -   2: conta corrente com cheque especial   -   3: conta poupança 

            Console.Write("Insira o saldo de cada conta bancária\n");

            Console.Write(" 1. Saldo da conta corrente: "); //saldo da conta corrente
            conta_corrente = double.Parse(Console.ReadLine());

            Console.Write(" 2. Saldo da conta corrente com cheque especial: "); //valor de saldo da conta corrente com cheque especial
            conta_cheque = double.Parse(Console.ReadLine());

            Console.Write(" Limite de cheque especial: "); //valor de limite do cheque especial
            limite_cheque = double.Parse(Console.ReadLine());

            saldo_conta_cheque = conta_cheque + limite_cheque; //saldo da conta corrente com cheque especial = saldo + limite de cheque
            limite_cheque_update = limite_cheque;

            Console.Write(" 3. Saldo da conta poupança: "); //saldo da conta poupança
            poupanca = double.Parse(Console.ReadLine());
            Console.WriteLine();

            do
            {
                
                count += 1;// Variavel que conta a execucao do menu para atualizar a poupança.

                if (count == 5)// Condicional que verifica atualização da poupança + cobrança dos juros de cheque especial.
                {
                    poupanca_rend = poupanca * poupanca_tax;
                    poupanca = poupanca + poupanca_rend;
                    Console.WriteLine($"Você tem novos rendimentos na sua conta.\n\nA sua poupança rendeu: R${poupanca_rend}  \nSaldo da conta poupança: R${poupanca}\n");
                    count = 0;

                    if (conta_cheque == 0 || conta_cheque <0)//Condicional que verifica cobrança de juros do cheque especial se for utilizado.
                    {
                        Console.WriteLine($"\nQual a taxa de juros ao mês do seu cheque especial em %? ");
                        juros_especial = double.Parse(Console.ReadLine());
                        especial_valor = (limite_cheque) * (juros_especial / 100);

                        Console.WriteLine($"\nO valor da taxa do seu cheque especial a pagar é de: {especial_valor}\nComo deseja efetuar o pagamento?");

                        Console.WriteLine("\n1: conta corrente\n2: conta corrente com cheque especial\n3: conta poupança\n\nInsira a conta em que deseja realizar a operacao: ");
                        numero_conta = int.Parse(Console.ReadLine());

                        if (numero_conta == 1)
                        {
                            conta_corrente = conta_corrente - especial_valor;
                            Console.WriteLine($"\nPagamento efetuado!\nO saldo de sua conta corrente é de: {conta_corrente}\n");
                        }
                        else if (numero_conta == 2)
                        {
                            conta_cheque = conta_cheque - especial_valor;                            
                            saldo_conta_cheque = saldo_conta_cheque - especial_valor;
                            Console.WriteLine($"\nPagamento efetuado!\nO saldo de seu cheque especial é de: {conta_cheque}\n");
                        }
                        else if (numero_conta == 3)
                        {
                            poupanca = poupanca - especial_valor;
                            Console.WriteLine($"\nPagamento efetuado!\nO saldo de sua conta poupança é de: {poupanca}\n");
                        }
                        else
                        {
                            for (i = 0; i < 100; i++)
                            {
                                Console.WriteLine("\nDigite um número válido de 1 a 3!\n");
                                Console.WriteLine("\n1: conta corrente\n2: conta corrente com cheque especial\n3: conta poupança\n\nInsira a conta em que deseja realizar a operacao: ");
                                numero_conta = int.Parse(Console.ReadLine());
                                if (numero_conta == 1)
                                {
                                    conta_corrente = conta_corrente - especial_valor;
                                    Console.WriteLine($"\nPagamento efetuado!\nO saldo de sua conta corrente é de: {conta_corrente}\n");
                                    i = 100;
                                }
                                else if (numero_conta == 2)
                                {
                                    saldo_conta_cheque = saldo_conta_cheque - especial_valor;
                                    Console.WriteLine($"\nPagamento efetuado!\nO saldo de seu cheque especial é de: {conta_cheque}\n");
                                    i = 100;
                                }
                                else if (numero_conta == 3)
                                {
                                    poupanca = poupanca - especial_valor;
                                    Console.WriteLine($"\nPagamento efetuado!\nO saldo de sua conta poupança é de: {poupanca}\n");
                                    i = 100;
                                }
                                else
                                {
                                    Console.WriteLine("\nDigite um número válido de 1 a 3!\n");

                                }
                            }
                        }

                    }

                }


                Console.Write("Menu de operações:\n 1. Consultar saldo\n 2. Realizar saque\n 3. Realizar depósito\n 4. Efetuar um pagamento de contas\n 5. Realizar transferência\n 6. Encerrar programa\n");

                Console.Write("\nInforme qual operação deseja realizar: ");
                n_operacao = int.Parse(Console.ReadLine());
                if ((n_operacao > 6) || (n_operacao < 1))// Validação do Menu de Operações
                {
                    Console.WriteLine("\nPor favor, insira um valor entre 1 e 6.\n");
                }
                else if (n_operacao == 6)//break do while
                {
                    Console.WriteLine("Obrigado volte sempre!");
                }
                else
                {
                    Console.WriteLine("\n1: conta corrente\n2: conta corrente com cheque especial\n3: conta poupança\n\nInsira a conta em que deseja realizar a operacao: ");
                    numero_conta = int.Parse(Console.ReadLine());
                    if ((numero_conta < 1 || numero_conta > 3))
                    {
                        Console.WriteLine("\nPor favor, insira um valor entre 1 e 3.\n");// Validação das contas a serem selecionadas.
                    }
                    else
                    {


                        if (n_operacao == 1 && numero_conta == 1)// Operação de Consulta
                        {

                            Console.WriteLine($"\nSaldo da conta corrente: {conta_corrente}\n");
                        }

                        if (n_operacao == 1 && numero_conta == 2)
                        {

                            Console.WriteLine($"\nSaldo da conta corrente com cheque especial: {conta_cheque}\n");
                        }

                        if (n_operacao == 1 && numero_conta == 3)
                        {

                            Console.WriteLine($"\nSaldo da poupança: {poupanca}\n");
                        }

                        if (n_operacao == 2 && numero_conta == 1)// Operação de Saque
                        {
                            Console.WriteLine("Qual o valor do saque? ");
                            saque = double.Parse(Console.ReadLine());
                            if (saque <= conta_corrente)
                            {
                                conta_corrente = conta_corrente - saque;
                            }
                            else
                            {
                                Console.WriteLine("\n Você não tem saldo para realizar essa operação.");
                            }
                            Console.WriteLine($"\n O saldo da sua conta corrente é de: {conta_corrente}.\n");
                        }

                        if (n_operacao == 2 && numero_conta == 2)
                        {
                            Console.WriteLine("Qual o valor do saque? ");
                            saque = double.Parse(Console.ReadLine());

                            if (saque <= saldo_conta_cheque)
                            {
                                conta_cheque = conta_cheque - saque;
                                saldo_conta_cheque = saldo_conta_cheque - saque;
                            }
                            else
                            {
                                Console.WriteLine("\n Você não tem saldo para realizar essa operação.");
                            }
                            Console.WriteLine($"\n O saldo do seu cheque especial é de: {conta_cheque}.\n");
                        }

                        if (n_operacao == 2 && numero_conta == 3)
                        {
                            Console.WriteLine("Qual o valor do saque? ");
                            saque = double.Parse(Console.ReadLine());
                            if (saque <= poupanca)
                            {
                                poupanca = poupanca - saque;
                            }
                            else Console.WriteLine("\n Você não tem saldo para realizar essa operação.");

                            Console.WriteLine($"\n O saldo da sua conta poupança é de: {poupanca}.\n");
                        }
                        if (n_operacao == 3 && numero_conta == 1)// Operação de Depósito
                        {
                            Console.WriteLine("Digite o valor do depósito: ");
                            deposito = double.Parse(Console.ReadLine());
                            if (deposito > 0)
                            {
                                conta_corrente = conta_corrente + deposito;
                            }
                            else Console.WriteLine("\n Por favor insira um valor válido.");

                            Console.WriteLine($"\n O saldo da sua conta corrente é de: {conta_corrente}.\n");
                        }
                        if (n_operacao == 3 && numero_conta == 2)
                        {
                            Console.WriteLine("Digite o valor do depósito: ");
                            deposito = double.Parse(Console.ReadLine());
                            if (deposito > 0)
                            {
                                if (conta_cheque < 0)
                                {
                                    conta_cheque = 0;
                                    conta_cheque = conta_cheque + deposito;
                                    saldo_conta_cheque = saldo_conta_cheque + deposito;
                                }
                                else
                                {
                                    conta_cheque = conta_cheque + deposito;
                                    saldo_conta_cheque = saldo_conta_cheque + deposito;
                                }
                            }
                            else Console.WriteLine("\n Por favor insira um valor válido.");

                            Console.WriteLine($"\n O saldo de seu cheque especial é de: {conta_cheque} .\n");
                        }
                        if (n_operacao == 3 && numero_conta == 3)
                        {
                            Console.WriteLine("Digite o valor do depósito: ");
                            deposito = double.Parse(Console.ReadLine());
                            if (deposito > 0)
                            {
                                poupanca = poupanca + deposito;
                            }
                            else Console.WriteLine("\n Por favor insira um valor válido.");

                            Console.WriteLine($"\n O saldo da sua conta poupanca é de: {poupanca}.\n");
                        }
                        if (n_operacao == 4 && numero_conta == 1)// Operação de Pagamento de Contas
                        {
                            Console.WriteLine("\nInforme o valor das contas: ");

                            Console.Write("Água: ");
                            agua = double.Parse(Console.ReadLine());

                            Console.Write("Luz: ");
                            luz = double.Parse(Console.ReadLine());

                            Console.Write("Telefone: ");
                            telefone = double.Parse(Console.ReadLine());

                            Console.WriteLine("\nExiste outra conta?\nDigite 1 para sim e 0 para não.\n");
                            outro = int.Parse(Console.ReadLine());

                            if (outro == 1)
                            {
                                Console.Write("Digite o valor: ");
                                valor_outro = double.Parse(Console.ReadLine());
                                conta_total = agua + luz + telefone + valor_outro;
                                Console.WriteLine($"\nO total a pagar é: {conta_total}. Deseja efetuar o pagamento?\nDigite 1 para sim e 0 para não.");
                                outro = int.Parse(Console.ReadLine());

                                if (outro == 1)
                                {
                                    if (conta_total > conta_corrente)
                                    {
                                        Console.WriteLine("Seu saldo não é suficiente para realizar o pagamento.\n");
                                    }
                                    else
                                    {
                                        conta_corrente = conta_corrente - conta_total;
                                        Console.WriteLine("\nPagamento efetuado.");
                                        Console.WriteLine($"O Saldo da conta corrente é: {conta_corrente}.\n");
                                    }
                                }
                            }
                            else if (outro == 0)
                            {
                                conta_total = agua + luz + telefone + outro;
                                Console.WriteLine($"\nO total a pagar é: {conta_total}. Deseja efetuar o pagamento?\nDigite 1 para sim e 0 para não.");
                                outro = int.Parse(Console.ReadLine());
                                if (outro == 1)
                                {
                                    if (conta_total > conta_corrente)
                                    {
                                        Console.WriteLine("Seu saldo não é suficiente para realizar o pagamento.\n");
                                    }
                                    else
                                    {
                                        conta_corrente = conta_corrente - conta_total;
                                        Console.WriteLine("\nPagamento efetuado.");
                                        Console.WriteLine($"O Saldo da conta poupança é: {conta_corrente}.\n");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Insira um valor válido.");
                            }

                        }
                        if (n_operacao == 4 && numero_conta == 2)
                        {
                            Console.WriteLine("\nInforme o valor das contas: ");

                            Console.Write("Água: ");
                            agua = double.Parse(Console.ReadLine());

                            Console.Write("Luz: ");
                            luz = double.Parse(Console.ReadLine());

                            Console.Write("Telefone: ");
                            telefone = double.Parse(Console.ReadLine());

                            Console.WriteLine("\nExiste outra conta?\nDigite 1 para sim e 0 para não.\n");
                            outro = int.Parse(Console.ReadLine());

                            if (outro == 1)
                            {
                                Console.Write("Digite o valor: ");
                                valor_outro = double.Parse(Console.ReadLine());
                                conta_total = agua + luz + telefone + valor_outro;
                                Console.WriteLine($"\nO total a pagar é: {conta_total}. Deseja efetuar o pagamento?\nDigite 1 para sim e 0 para não.");
                                outro = int.Parse(Console.ReadLine());

                                if (outro == 1)
                                {
                                    if (conta_total > saldo_conta_cheque)
                                    {
                                        Console.WriteLine("Seu saldo não é suficiente para realizar o pagamento.\n");
                                    }
                                    else
                                    {
                                        conta_cheque = conta_cheque - conta_total;
                                        saldo_conta_cheque = saldo_conta_cheque - conta_total;
                                        Console.WriteLine("\nPagamento efetuado.");
                                        Console.WriteLine($"O seu saldo do cheque especial é: {conta_cheque}.\n");
                                    }
                                }
                            }
                            else if (outro == 0)
                            {
                                conta_total = agua + luz + telefone + outro;
                                Console.WriteLine($"\nO total a pagar é: {conta_total}. Deseja efetuar o pagamento?\nDigite 1 para sim e 0 para não.");
                                outro = int.Parse(Console.ReadLine());
                                if (outro == 1)
                                {
                                    if (conta_total > saldo_conta_cheque)
                                    {
                                        Console.WriteLine("Seu saldo não é suficiente para realizar o pagamento.\n");
                                    }
                                    else
                                    {
                                        conta_cheque = conta_cheque - conta_total;
                                        saldo_conta_cheque = saldo_conta_cheque - conta_total;
                                        Console.WriteLine("\nPagamento efetuado.");
                                        Console.WriteLine($"O Saldo do cheque especial é: {conta_cheque}.\n");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Insira um valor válido.");
                            }

                        }
                        if (n_operacao == 4 && numero_conta == 3)
                        {
                            Console.WriteLine("\nInforme o valor das contas: ");

                            Console.Write("Água: ");
                            agua = double.Parse(Console.ReadLine());

                            Console.Write("Luz: ");
                            luz = double.Parse(Console.ReadLine());

                            Console.Write("Telefone: ");
                            telefone = double.Parse(Console.ReadLine());

                            Console.WriteLine("\nExiste outra conta?\nDigite 1 para sim e 0 para não.\n");
                            outro = int.Parse(Console.ReadLine());

                            if (outro == 1)
                            {
                                Console.Write("Digite o valor: ");
                                valor_outro = double.Parse(Console.ReadLine());
                                conta_total = agua + luz + telefone + valor_outro;
                                Console.WriteLine($"\nO total a pagar é: {conta_total}. Deseja efetuar o pagamento?\nDigite 1 para sim e 0 para não.");
                                outro = int.Parse(Console.ReadLine());

                                if (outro == 1)
                                {
                                    if (conta_total > poupanca)
                                    {
                                        Console.WriteLine("Seu saldo não é suficiente para realizar o pagamento.\n");
                                    }
                                    else
                                    {
                                        poupanca = poupanca - conta_total;
                                        Console.WriteLine("\nPagamento efetuado.");
                                        Console.WriteLine($"O Saldo da conta poupança é: {poupanca}.\n");
                                    }
                                }
                            }
                            else if (outro == 0)
                            {
                                conta_total = agua + luz + telefone + outro;
                                Console.WriteLine($"\nO total a pagar é: {conta_total}. Deseja efetuar o pagamento?\nDigite 1 para sim e 0 para não.");
                                outro = int.Parse(Console.ReadLine());
                                if (outro == 1)
                                {
                                    if (conta_total > poupanca)
                                    {
                                        Console.WriteLine("Seu saldo não é suficiente para realizar o pagamento.\n");
                                    }
                                    else
                                    {
                                        poupanca = poupanca - conta_total;
                                        Console.WriteLine("\nPagamento efetuado.");
                                        Console.WriteLine($"O Saldo da conta poupança é: {poupanca}.\n");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Insira um valor válido.");
                            }

                        }
                        if (n_operacao == 5 && numero_conta == 1)// Operação de Transferência
                        {
                            Console.WriteLine("\nQual o destinatário da transferência? ");
                            destinatario = Console.ReadLine();

                            Console.WriteLine("Qual o valor da transferência? ");
                            transf_value = double.Parse(Console.ReadLine());

                            Console.WriteLine($"\nDeseja realizar a transferência para {destinatario} no valor de R${transf_value}? \nDigite 1 para sim e 0 para não.");
                            outro = int.Parse(Console.ReadLine());
                            if (outro == 1)
                            {
                                if (transf_value > conta_corrente)
                                {
                                    Console.WriteLine("\nSeu saldo não é suficiente para realizar a operação.\n");
                                }
                                else
                                {
                                    conta_corrente = conta_corrente - transf_value;
                                    Console.WriteLine($"\nTransferência para {destinatario} no valor de R${transf_value} realizada com sucesso!");
                                    Console.WriteLine($"O saldo de sua conta corrente é: R${conta_corrente}\n");
                                }
                            }
                        }
                        if (n_operacao == 5 && numero_conta == 2)
                        {
                            Console.WriteLine("\nQual o destinatário da transferência? ");
                            destinatario = Console.ReadLine();

                            Console.WriteLine("Qual o valor da transferência? ");
                            transf_value = double.Parse(Console.ReadLine());

                            Console.WriteLine($"\nDeseja realizar a transferência para {destinatario} no valor de R${transf_value}? \nDigite 1 para sim e 0 para não.");
                            outro = int.Parse(Console.ReadLine());
                            if (outro == 1)
                            {
                                if (transf_value > saldo_conta_cheque)
                                {
                                    Console.WriteLine("\nSeu saldo não é suficiente para realizar a operação.\n");
                                }
                                else
                                {
                                    conta_cheque = conta_cheque - transf_value;
                                    saldo_conta_cheque = saldo_conta_cheque - transf_value;
                                    Console.WriteLine($"\nTransferência para {destinatario} no valor de R${transf_value} realizada com sucesso!");
                                    Console.WriteLine($"O saldo de seu cheque especial é: R${conta_cheque}\n");
                                }
                            }
                        }
                        if (n_operacao == 5 && numero_conta == 3)
                        {
                            Console.WriteLine("\nQual o destinatário da transferência? ");
                            destinatario = Console.ReadLine();

                            Console.WriteLine("Qual o valor da transferência? ");
                            transf_value = double.Parse(Console.ReadLine());

                            Console.WriteLine($"\nDeseja realizar a transferência para {destinatario} no valor de R${transf_value}? \nDigite 1 para sim e 0 para não.");
                            outro = int.Parse(Console.ReadLine());
                            if (outro == 1)
                            {
                                if (transf_value > poupanca)
                                {
                                    Console.WriteLine("\nSeu saldo não é suficiente para realizar a operação.\n");
                                }
                                else
                                {
                                    poupanca = poupanca - transf_value;
                                    Console.WriteLine($"\nTransferência para {destinatario} no valor de R${transf_value} realizada com sucesso!");
                                    Console.WriteLine($"O saldo de sua conta poupança é: R${poupanca}\n");
                                }
                            }
                        }

                    }
                }
            } while (n_operacao != 6);



            Console.ReadKey();

        }
    }
}