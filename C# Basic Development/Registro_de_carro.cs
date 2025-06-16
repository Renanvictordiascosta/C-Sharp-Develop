// Chamada de namespace System
using System;

// Criação de um namespace
namespace Codificador {

	// Classe para registro de carros
	public class Carro {
	
		// Criação das propriedades privadas 
		private string marca { get; set; }
		private string modelo { get; set; }
		private int ano { get; set; }
		
		// Propriedade pública "Marca" para manipular o valor da propriedade privada "marca" 
		public string Marca {
		
			get => marca;
			
			set {
				
				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) {
					
					marca = "Garbage";
					
				}
					
				else { marca = value; }  
		
			}
		
		}
		
		// Propriedade pública "Modelo" para manipular o valor da propriedade privada "modelo"
		public string Modelo {
		
			get => modelo;
			
			set {
				
				if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)) {
					
					modelo = "Truck";
					
				}
					
				else { modelo = value; }
				
			}
		
		}
		
		// Propriedade pública "Ano" para manipular o valor da propriedade privada "ano"
		public int Ano {
		
			get => ano;
			
			set {
				
				if (value < 1960 || value > 2100) {
				
					ano = 1950;
				
				}
				
				else { ano = value; } 
				
			}
		
		}
		
		// Construtor carro
		public Carro (string marca, string modelo, int ano) {
		
			Marca = marca;
			Modelo = modelo;
			Ano = ano;
		
		}
		
		// Método para print no console do carro específico que foi cadastrado com base nos três critérios
		public void Carro_Especifico () {
		
			Console.WriteLine($"Carro Específico: {Marca}-{Modelo}-{Ano}");
		
		}
	
	}
	
	// Classe principal
	public class Program {
	
		// Método "Main"
		public static void Main(string[] args) {
	
			// Variáveis que terão seus valores atribuídos
			Console.Write("Marca do carro: ");
			string marca = Console.ReadLine();
				
			Console.Write("Modelo do carro: ");
			string modelo = Console.ReadLine();
				
			Console.Write("Ano de lançamento: ");
			int ano = Convert.ToInt32(Console.ReadLine());
	
			// Instância "carro" da classe "Carro" com os valores das variáveis inseridas no Construtor
			Carro carro = new Carro(marca, modelo, ano);
			
			// Chamada de um método da classe
			carro.Carro_Especifico();
			
		}
	
	}

}
