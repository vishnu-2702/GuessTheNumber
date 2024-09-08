namespace GuessTheNumber
{
  class GuessTheNumber
  {

    static string evaluateGuess(int Number, int Guess){
        int a = Number;
        int b = Guess;

        if (a == b){
            return "correct";
        }
        if (b < a ){
            return "the guess is low";
        }
        if (b > a){
            return "guess is high";
        }
        return "";
    }

    static void Main(string[] args)
    {
      Random random= new Random();
      int number = random.Next(11);

      Console.WriteLine("Guess the number i am thinking between 1 - 10");

      int tries = 0;
      string result =  "";
      int guess;

      while(result != "correct"){
        guess = Convert.ToInt32(Console.ReadLine());
        tries ++;
        result = evaluateGuess(number, guess);
        Console.WriteLine(result);

        if (result == "correct"){
            Console.WriteLine($"You have guessed it right in {tries} tries");
        }
      }
      Console.ReadLine();
    }
  }
}