class CaixaEletronico
{
    static void Main()
    {
        double saldo = 1000.00;
        while (true)
        {
            Console.WriteLine("\n--- Caixa Eletrônico ---");
            Console.WriteLine("1. Consultar Saldo");
            Console.WriteLine("2. Sacar");
            Console.WriteLine("3. Depositar");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"Seu saldo é: R$ {saldo:F2}");
                    break;
                case 2:
                    Console.Write("Digite o valor para sacar: ");
                    double saque = double.Parse(Console.ReadLine());
                    if (saque > saldo)
                        Console.WriteLine("Saldo insuficiente!");
                    else
                    {
                        saldo -= saque;
                        Console.WriteLine("Saque realizado com sucesso!");
                    }
                    break;
                case 3:
                    Console.Write("Digite o valor para depositar: ");
                    double deposito = double.Parse(Console.ReadLine());
                    saldo += deposito;
                    Console.WriteLine("Depósito realizado com sucesso!");
                    break;
                case 4:
                    Console.WriteLine("Obrigado por utilizar o caixa eletrônico!");
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
