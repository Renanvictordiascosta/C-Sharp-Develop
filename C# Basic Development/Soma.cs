// Chamada da namespace
using System;

// Criação do espaço para redigir as classes
namespace ProjetoDeTeste {

// Criação da classe
    public class Soma {

// Criação da função principal
        public static void Main(string[] args) {

// Solicitação para digitação de valor 1 
            Console.Write("Digite o primeiro valor: ");
            float x = float.Parse(Console.ReadLine());

// Solicitação para digitação de valor 2
            Console.Write("Digite o segundo valor: ");
            float y = float.Parse(Console.ReadLine());

// Geração de um terceiro valor com base nas atribuições dos dois anteriores
            float z = (x + y) / 2;
            Console.WriteLine("O valor da soma é " + z);

        }

    }

}
