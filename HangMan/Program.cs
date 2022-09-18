namespace HangMan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "Hello";
            string guessedWord = "";
            int count = 0;
            int countLimit = 10;
            bool isChansesOver = false;

            while (guessedWord != secretWord && !isChansesOver)
            {
                if (count < countLimit)
                {
                    Console.WriteLine("Guess the Word: ");
                    guessedWord = Console.ReadLine();
                    count++;
                }
                else
                {
                    isChansesOver = true;

                }
            }
            if (isChansesOver)
            {
                Console.WriteLine("Sorry! You Lose, Game is over!");
            }
            else
            {
                Console.WriteLine("Congs You Win!");
            }
            Console.ReadKey();
        }



    }
}