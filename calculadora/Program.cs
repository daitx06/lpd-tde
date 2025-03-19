class Calculadora
{
    static void Main()
    {
        Console.WriteLine("\n--- Calculadora Simples ---");
        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Digite o operador (+, -, *, /): ");
        char operador = Console.ReadKey().KeyChar;
        Console.Write("\nDigite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = 0;
        switch (operador)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    resultado = num1 / num2;
                else
                {
                    Console.WriteLine("\nErro: Divisão por zero!");
                    return;
                }
                break;
            default:
                Console.WriteLine("\nOperador inválido!");
                return;
        }
        Console.WriteLine($"Resultado: {resultado}");
    }
}
