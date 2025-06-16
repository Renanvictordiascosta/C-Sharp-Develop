// Chamada de namespaces e classes
using System;
using System.Data;

// Espaço de armazenamento de classes
namespace ProjetoDeTeste {

    // Classe para tratamento de senhas
    class ValidadorDeSenha {

        // Função principal dentro da classe programa
        public static void Main(string[] args) {

            // Leitura dos dados de senha
            Console.Write("Digite uma senha: ");
            string senha = Console.ReadLine();

            // Atribuição dos parâmetros para senha
            bool tamanho = senha.Length >= 8;
            
            bool valor1 = senha.Any(char.IsUpper);
            
            bool valor2 = senha.Any(char.IsDigit);

            // Averiguação se a senha atende os parâmetros
            if(tamanho && valor1 && valor2) {

                Console.WriteLine("Senha válida!");

            } else {

                Console.WriteLine("Senha Inválida!");

            }

        }

    }

}
