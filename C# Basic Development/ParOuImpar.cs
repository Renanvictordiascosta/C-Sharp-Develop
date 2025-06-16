// Chamada de namespaces e classes
using System;

// Espaço de armazenamento de classes
namespace ProjetoDeTeste {

    // Classe de identificação se é ímpar ou par
    class ParOuImpar {

        // Função principal dentro da classe programa
        public static void Main(string[] args) {

            try {

                Console.Write("Digite um número inteiro: ");

                /* Leitura do valor como string 
                ,transformação dele em int
                e print do valor */
                string input = Console.ReadLine();
                
                int number = int.Parse(input);
                Console.WriteLine($"Você digitou: {number}");

            }

            // Verificação se o número é no formato adequado
            catch (FormatException) {
                
                Console.WriteLine("Por favor, digite um número válido.");
            
            }

            // Verificação se o número é muito grande
            catch (OverflowException) {

                Console.WriteLine("O número digitado é muito grande.");
                
            }

        }

    }

}

