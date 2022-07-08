using System;
using System.Linq;

namespace Exercicios
{
	class Program
	{
		static void Main(string[] args)
		{

			/*
			 * 1) A partir do código a seguir, esse projeto deve ser capaz de receber uma lista de números via argumentos de linha de comando
			 * e passá-lo para o método SomaNumerosPares(). Esse método deve ser alterado para retornar o valor resultante da soma dos números 
			 * pares lidos pela entrada.
			 *
			 */

			//Declaração da Array
			int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			int SomaNumerosPares()
			{
				int soma = 0;
				//Armazenar a soma dos numeros pares
				for (int i = 0; i < numeros.Length; i++)
				{
					if (numeros[i] % 2 == 0)
					{
						soma += numeros[i];

					}
				}
				Console.WriteLine($"A soma dos números pares encontrados é {soma}");
				return soma;
			}

			//SomaNumerosPares();

			//Console.ReadKey();


			/**
			 * 2) Com base no código abaixo, realize a validação dos dados que estão sendo recebidos.
			 * 
			 * As regras a serem utilizadas:
			 * * Nome não pode ser vazio e deve ter até 100 caracteres
			 * * Idade deve ser um dígito numérico inteiro e positivo
			 * * Data de nascimento deve ser uma data válida no formato dia/mês/ano e deve ser uma data no passado
			 * 
			 * As validações devem ser seguras em relação a não permitir o encerramento do programa de maneira abrupta por Exceptions, de forma
			 * que qualquer dado inválido deve resultar numa mensagem via Console.WriteLine() para o usuário.
			 * 
			 * As validações devem ser feitas apenas após o recebimento de todos os dados e deve ser exibido, linha a linha, o resultado da 
			 * validação, seja informando um erro de validação ou um sucesso de que o dado é válido.
			 * 
			 * Exemplo de saída esperada:
			 * 
			 * Preencha o nome:
			 * Preencha a idade:
			 * Preencha a data de nascimento:
			 * 
			 * Resultados da validação
			 * 
			 * Nome válido!
			 * Idade não é um número positivo (-5)
			 * Data de nascimento não pode ser uma data no futuro (01/04/2202)
			*/
			bool ValidaNome()
			{
				Console.WriteLine("Informe o seu nome: ");
				string nome = Console.ReadLine();

				if (nome.All(char.IsDigit) || nome.Length > 100)
				{
					Console.WriteLine("Nome inválido");
					return false;
				}
				else
				{
					Console.WriteLine("Nome válido");
					return true;
				}
					
			}

			bool ValidaIdade()
            {
				Console.WriteLine("informe o sua idade: ");
				int idade = int.Parse(Console.ReadLine());

				if (idade < 0)
				{
					Console.WriteLine($"Idade não é um número positivo {idade}");
					return false;
				}
				else
				{
					Console.WriteLine("Idade válida");
					return true;
				}
			}

            while (!ValidaNome())
            {
				ValidaNome();
				if (ValidaNome())
					break;
            }

			while (!ValidaIdade())
            {
				ValidaIdade();
				if (ValidaIdade())
					break;
			}

			Console.WriteLine("Informações validadas!");

			//Console.WriteLine("Informe sua data de nascimento: ");
			//DateTime data_nascimento_informado = DateTime.Parse(Console.ReadLine());



			/**
			 * 3) Considere a classe Solicitacao definida ao final do arquivo e complete os métodos do código abaixo para retornarem 
			 * dados específicos da lista de solicitação, conforme os filtros especificados.
			 * 
			 * O método RetornarTotalSolicitacoesCriadasEntre() deve retornar o total de solicitações com a data de criação entre 
			 * duas datas que podem ou não serem passadas (null)
			 * 
			 * O método RetornarSolicitacoesCriadasEntre() deve retornar uma lista de objetos de solicitação com a data de criação entre 
			 * duas datas que podem ou não serem passadas (null)
			 * 
			 * O método RetornarSolicitacoesAbertas() deve retornar uma lista de objetos de solicitação que não possuam data de encerramento (null)
			*/


			/**
			 * 4) Com base no código abaixo, crie a classe Cep de forma que ela possa completar o programa.
			 * 
			 * A regra de validação do CEP deve consistir em:
			 * * a string deve ter apenas 8 caracteres numéricos
			 * * não pode ter letras e outros tipos de caracteres, como espaço ou traço
			 * 
			 * A regra de formação do CEP deve ser de exibir o CEP no formato NNNNN-NNN (5 números + traço + 3 números)
			 * 
			 * Exemplo de entrada correta: 71060240
			 * Exemplo de saída: O CEP 71060-240 é válido!
			 * 
			 * Exemplo de entrada incorreta: 38402-046
			 * Exemplo de saída: CEP inválido!
			*/






		}
	}
}
