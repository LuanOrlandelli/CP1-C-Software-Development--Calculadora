using System;

class Program
{
    static void Main(string[] args)
    {
        int Opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("Calculadora (Adição / Subtração / Multiplicação / Divisão)");
            Console.WriteLine();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");

            Console.Write("\nDigite a opção desejada: ");
            Opcao = int.Parse(Console.ReadLine());

            if (Opcao >= 1 && Opcao <= 4)
            {
                Console.Write("Digite o primeiro número: ");
                double Numero1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                double Numero2 = double.Parse(Console.ReadLine());

                double Resultado = 0;

                switch (Opcao)
                {
                    case 1:
                        Resultado = Numero1 + Numero2;
                        Console.WriteLine("Resultado da Adição: " + Resultado);
                        break;

                    case 2:
                        Resultado = Numero1 - Numero2;
                        Console.WriteLine("Resultado da Subtração: " + Resultado);
                        break;

                    case 3:
                        Resultado = Numero1 * Numero2;
                        Console.WriteLine("Resultado da Multiplicação: " + Resultado);
                        break;

                    case 4:
                        if (Numero2 == 0)
                        {
                            Console.WriteLine("Erro: Não é possível dividir por zero.");
                        }
                        else
                        {
                            Resultado = Numero1 / Numero2;
                            Console.WriteLine("Resultado da Divisão: " + Resultado);
                        }
                        break;
                }
            }
            else if (Opcao != 5)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }

            if (Opcao != 5)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }

        } while (Opcao != 5);

        Console.WriteLine("Programa encerrado.");
    }
}
