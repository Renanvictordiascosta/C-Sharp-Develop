// Chamada das namespaces e classes
using System;
using System.Collections.Generic;
using System.Threading;

// Criação do espaço para redigir as classes
namespace ProjetoDeTeste {

// Criação da classe
    public class Opcoes {

// Criação da função principal
        public static void Main(string[] args) {
            
            int opcao = 1;

// Criação do loop de operação
            while (opcao != 2) {

                Console.WriteLine("Olá, essa é a página de escolha de opção!");
                Thread.Sleep(2000);

                Console.WriteLine("Escolha uma das seguintes opções!");
                Thread.Sleep(1500);

                Console.WriteLine("(1) Entrando");
                Thread.Sleep(1000);

                Console.WriteLine("(2) Saindo");
                Thread.Sleep(1000);

                Console.Write("Escolha uma opção: ");
                
// Realizar a operação buscando o tratamento das excessões
                try {
                
                    opcao = int.Parse(Console.ReadLine());
                
                    switch (opcao) {

// Caso a opção selecionada seja a número um
                        case 1:

                            Console.WriteLine("Entrando no sistema!");
                            Thread.Sleep(2000);
                        
                            Console.WriteLine("Você perpetou um loop!");
                            Thread.Sleep(1000);
                            break;

// Caso a opção escolhida seja a número dois
                        case 2:

                            Console.WriteLine("Entendo que queira sair do sistema.");
                            Thread.Sleep(2000);

                            Console.WriteLine("Tenha um excelente dia!");
                            Thread.Sleep(1000);
                            break;

// Caso nenhuma das duas operações acima sejam satisfeitas
                        default:

                            Console.WriteLine("Você digitou uma opção inválida!");
                            Thread.Sleep(1000);
                            break;

                    }

// Tratamento da exceção em caso de valor do input não ser inteiro
                } catch(FormatException) {

                    Console.WriteLine("Você digitou um valor inválido!");
                    Thread.Sleep(1000);

                }
                    
            }
            
        }

    }

}

