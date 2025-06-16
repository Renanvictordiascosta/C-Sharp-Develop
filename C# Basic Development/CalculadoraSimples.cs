// Chamada de namespaces e classes
using System;
using System.Data;
using System.Threading;

// Espaço de armazenamento de classes
namespace ProjetoDeTeste {

    // Classe de execução das funções da calculadora simples
    public class CalculadoraSimples {

        // Função principal
        public static void Main(string[] args) {

            string opcao = " ";

            // Loop para execução do sistema
            while (opcao != "2") {

                // Mensagens geradas a cada execução do loop
                Console.WriteLine("Olá, esse é o sistema de calculadora!");
                Thread.Sleep(2000);
                
                Console.WriteLine("Ela permite que você digite suas expressões matemáticas e retorna o valor dessa expressão!");
                Thread.Sleep(2000);
                
                Console.WriteLine("Digite qual opção você deseja realizar:");
                Thread.Sleep(2000);

                Console.WriteLine("(1) Realizar o cálculo de uma expressão matemática");
                Thread.Sleep(1000);

                Console.WriteLine("(2) Sair do Sistema");
                Console.WriteLine(" ");
                Thread.Sleep(1000);

                Console.Write("Qual a opção desejada: ");

                // Atribuição e tratamento de valor da variável opção
                opcao = Console.ReadLine();

                opcao = opcao.Replace(" ", "");

                //  Tratamento de exceção
                try {

                    // Leitura dos inputs das opções
                    switch (opcao) {

                        // Execução caso o valor seja 1
                        case "1":

                            Console.Write("Digite a equação matemática: ");
                        
                            // Leitura da equação
                            string equacao = Console.ReadLine();

                            // Tratamento da equação
                            equacao = equacao.Replace(" ", "");

                            bool zero_divisao = equacao.Contains("/0");

                            double resultado = Calculadora(equacao);

                            // Caso uma divisão por zero seja detectada
                            if (zero_divisao) {

                                Console.WriteLine("Divisão por zero encontrado!");
                                Thread.Sleep(2000);

                            } else {

                                Console.WriteLine($"O resultado dessa equação é: {resultado}");
                                Thread.Sleep(2500);

                            }

                            break;

                        // Execução caso o valor seja 2
                        case "2":

                            Console.WriteLine("Obrigado por usar nosso sistema!");
                            Thread.Sleep(1500);

                            Console.WriteLine("Tenha um excelente dia!");
                            Thread.Sleep(1000);

                            break;

                        // Execução caso o valor seja inválido
                        default:

                            Console.WriteLine("Opção digitada é inválida!");
                            Thread.Sleep(1000);

                            break;

                    }

                // Executável em caso de exceção detectada
                } catch (Exception) {

                    Console.WriteLine("Caractere não processável detectado!");
                    Thread.Sleep(1000);

                }

            }

        }

        // Função privada onde será tratada a equação para devolver o resultado para a Main
        private static double Calculadora(string equacao) {

            /* Chamada de classe para identificar equações matemáticas
            com desde que somente tenham números (inteiros ou flutuantes)
            e os operadores "+", "-", "*" e "/" */
            DataTable data_table = new DataTable();

            // Chamada da função da classe para realizar essa operação matemática
            var calculo = data_table.Compute(equacao, null);

            // Conversão do valor gerado para double
            double resultado = Convert.ToDouble(calculo);

            return resultado;

        }

    }
    
}

