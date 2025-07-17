namespace Aula10;

public class Program
{
    public static void Main()
    {
        bool varContinue = true;

        while (varContinue)
        {
            Console.WriteLine("==========CALCULADORA SIMPLES==========");
            Console.WriteLine("Digite o primeiro numero:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha a operação:");
            Console.WriteLine("1- Adição (+)");
            Console.WriteLine("2- Subtração (-)");
            Console.WriteLine("3- Multiplicação (*)");
            Console.WriteLine("4- Divisão (/)");
            Console.WriteLine("Digite o numero da operação");
            int operation = Convert.ToInt32(Console.ReadLine());

            double result = 0;

            //Condiçoes 

            if (operation == 1)
            {
                result = num1 + num2;
            }
            else if (operation == 2)
            {
                result = num1 - num2;
            }
            else if (operation == 3)
            {
                result = num1 * num2;
            }
            else if (operation == 4)
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Erro: Divisao por zero nao é permitida.");
                }
            }
            else
            {
                Console.WriteLine("Operação inválida.");
            }

            Console.WriteLine("\nResultado = " + result + "\n");

            Console.Write("Deseja continuar? (s)/(n)");
            String response = Console.ReadLine();

            if (response != "s")
            {
                varContinue = false;

                Console.WriteLine("\nPrograma encerrado");
            }
            else
            {
                Console.WriteLine("\nContinuando...");
            }

            
        }

    }
}
