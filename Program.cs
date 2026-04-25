namespace GuessingGame;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 11);

        int guess = 0;
        int numberOfGuesses = 0;
        bool isCorrect = false;
        
        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("I have selected a secret number between 1 and 10. Can you guess it?\n");

        while (!isCorrect)
        {
            Console.Write("Your guess: ");
            string input = Console.ReadLine();
            
            bool isValidNumber = int.TryParse(input, out guess);

            if (!isValidNumber)
            {
                Console.WriteLine("Please, enter a valid number");
                continue;
            }

            numberOfGuesses++;

            if (guess < secretNumber)
            {
                Console.WriteLine("Too low, try higher");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Too high, try lower");
            }
            else
            {
                isCorrect = true;
            }
        }
        Console.WriteLine($"\n🎉 Correct! The number was {secretNumber}.");
        Console.WriteLine($"You got it in {numberOfGuesses} {(numberOfGuesses == 1 ? "guess" : "guesses")}!");
    }
}