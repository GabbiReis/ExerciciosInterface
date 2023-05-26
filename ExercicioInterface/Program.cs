using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExercicioInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IConta conta;

            Console.WriteLine("================== MENU ===================");
            Console.WriteLine("1 - CONTA CORRENTE");
            Console.WriteLine("2 - CONTA POUPANÇA");
            Console.WriteLine("3 - SAIR");
            Console.Write("Digite a opção desejada: ");
            int op = int.Parse(Console.ReadLine());

            do
            {
                switch (op)
                {
                    case 1:
                        Console.Clear();

                        Console.WriteLine("========== MENU CONTA CORRENTE ==========");
                        Console.WriteLine("1- DEPOSITAR");
                        Console.WriteLine("2- SACAR");
                        Console.WriteLine("3- SALDO");
                        Console.Write("Digite a opção desejada: ");
                        int opCorrente = int.Parse(Console.ReadLine());
                        conta = new Corrente();
                        switch (opCorrente)

                        {
                            case 1:

                                Console.WriteLine("Digite o valor que deseja depositar: ");
                                decimal valorDeposito = decimal.Parse(Console.ReadLine());
                                conta.Depositar(valorDeposito);
                                Console.WriteLine("Depósito realizado com sucesso!");
                                Console.WriteLine("Saldo Atual é de: " + conta.Saldo);
                                Console.Write("Pressione enter para continuar...");
                                break;
                            case 2:
                                Console.WriteLine("Digite o valor que deseja sacar: ");
                                decimal valorSaque = decimal.Parse(Console.ReadLine());
                                conta.Sacar(valorSaque);
                                Console.WriteLine("Saque realizado com sucesso!");
                                Console.WriteLine("Saldo Atual é de: " + conta.Saldo);
                                Console.Write("Pressione enter para continuar...");
                                break;
                            case 3:
                                Console.WriteLine("O Saldo atual é: ");
                                Console.WriteLine("Saldo: " + conta.Saldo);
                                Console.Write("Pressione enter para continuar...");
                                break;
                                
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("========== MENU CONTA POUPANCA ==========");
                        Console.WriteLine("1- DEPOSITAR");
                        Console.WriteLine("2- SACAR");
                        Console.WriteLine("3- SALDO");
                        Console.Write("Digite a opção desejada: ");
                        int opPoupanca = int.Parse(Console.ReadLine());
                        conta = new Poupanca();
                        switch (opPoupanca)

                        {
                            case 1:

                                Console.WriteLine("Digite o valor que deseja depositar: ");
                                decimal valorDeposito = decimal.Parse(Console.ReadLine());
                                conta.Depositar(valorDeposito);
                                Console.WriteLine("Depósito realizado com sucesso!");
                                Console.WriteLine("Saldo Atual é de: " + conta.Saldo);
                                Console.Write("Pressione enter para continuar...");
                                break;
                            case 2:
                                Console.WriteLine("Digite o valor que deseja sacar: ");
                                decimal valorSaque = decimal.Parse(Console.ReadLine());
                                conta.Sacar(valorSaque);
                                Console.WriteLine("Saque realizado com sucesso!");
                                Console.WriteLine("Saldo Atual é de: " + conta.Saldo);
                                Console.Write("Pressione enter para continuar...");
                                break;
                            case 3:
                                Console.WriteLine("O Saldo atual é: ");
                                Console.WriteLine("Saldo: " + conta.Saldo);
                                Console.Write("Pressione enter para continuar...");
                                break;
                                
                        }
                        break;


                    case 3:
                        System.Environment.Exit(1); ;
                        break;

                    default:
                        Console.WriteLine("Opção Inválida");
                        return;
               
                }
            } while (true);
            Console.ReadLine();
        }
    }
}
