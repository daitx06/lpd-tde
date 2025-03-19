class JogoAdivinhacao
{
    static void Main()
    {
        Random rand = new Random();
        int numeroSecreto = rand.Next(1, 101);
        int tentativa;

        Console.WriteLine("\n--- Jogo de Adivinhação ---");
        Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

        do
        {
            Console.Write("Digite seu palpite: ");
            tentativa = int.Parse(Console.ReadLine());

            if (tentativa < numeroSecreto)
                Console.WriteLine("Muito baixo! Tente novamente.");
            else if (tentativa > numeroSecreto)
                Console.WriteLine("Muito alto! Tente novamente.");
            else
                Console.WriteLine("Parabéns! Você acertou o número!");

        } while (tentativa != numeroSecreto);
    }
}
