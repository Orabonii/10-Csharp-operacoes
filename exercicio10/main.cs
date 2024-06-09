using System;

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o primeiro número:");
            double numero1;
            if (!double.TryParse(Console.ReadLine(), out numero1))
            {
                Console.WriteLine("Número inválido.");
                return;
            }

            Console.WriteLine("Digite o segundo número:");
            double numero2;
            if (!double.TryParse(Console.ReadLine(), out numero2))
            {
                Console.WriteLine("Número inválido.");
                return;
            }

            Console.WriteLine("Digite a operação (adição, subtração, multiplicação ou divisão):");
            string operacao = Console.ReadLine().ToLower();

            double resultado;

            switch (operacao)
            {
                case "adição":
                case "adicao":
                    resultado = numero1 + numero2;
                    break;
                case "subtração":
                case "subtracao":
                    resultado = numero1 - numero2;
                    break;
                case "multiplicação":
                case "multiplicacao":
                    resultado = numero1 * numero2;
                    break;
                case "divisão":
                case "divisao":
                    if (numero2 != 0)
                    {
                        resultado = numero1 / numero2;
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    return;
            }

            Console.WriteLine($"O resultado da {operacao} entre {numero1} e {numero2} é: {resultado}");
        }
    }










