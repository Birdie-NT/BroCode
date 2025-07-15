using System;

namespace BroCode
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      int x; //declaration
      x = 123; //initialisation

      int y = 321; //declaration +initialisation
      int z = x + y;

      int age_a = 21; // whole integer
      double height = 300.5; // decimal number
      bool alive = false;
      string name_a = "Bro";
      char symbol = '@';

      Console.WriteLine("Your name is " + name_a);
      Console.WriteLine("Your age is " + age_a);
      Console.WriteLine("Your height is " + height + "cm");
      Console.WriteLine("Are you alive " + alive);
      Console.WriteLine("Your symbol is " + symbol);

      // constants = immutable values which are known at compile time
      // and do not change for the life of the program

      const double pi = 3.14159;

      Console.WriteLine("the secret number is " + pi);

      //type casting = Converting a value to a different data type
      //               Useful when we accept user input 
      //               Different data types can do different things

      double a = 3.14;
      int b = Convert.ToInt32(a);

      int c = 123;
      double d = Convert.ToDouble(c) + 0.1;

      int e = 321;
      string f = Convert.ToString(e);

      Console.WriteLine(a);
      Console.WriteLine(a.GetType());

      //User Input:

      Console.WriteLine("What's your name?");
      string name = Console.ReadLine();

      Console.WriteLine("What is your age?");
      int age = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Hello " + name);
      Console.WriteLine("You are   " + age + " years old");

      // Random number:
      Random random = new Random();
      int num1 = random.Next(1, 7);
      int num2 = random.Next(1, 7) + 1;

      Console.WriteLine(num1);
      Console.WriteLine(num2);



      Random randomNum = new Random();
      bool playAgain = true;
      string player = "";
      string computer = "";
      string answer = "";

      while (playAgain)
      {
        while (player != "ROCK" && player != "PAPER" && player != "SCISSOR")
        {
          Console.Write("Enter ROCK, PAPER, or SCISSOR: ");
          player = Console.ReadLine();
          player = player.ToUpper();
        }

        switch (randomNum.Next(1, 4))
        {
          case 1:
            computer = "ROCK";
            break;
          case 2:
            computer = "PAPER";
            break;
          case 3:
            computer = "SCISSOR";
            break;
        }

        Console.WriteLine("Player: " + player);
        Console.WriteLine("Computer: " + computer);

        switch (player)
        {
          case "ROCK":
            if (computer == "ROCK")
            {
              Console.WriteLine("it's a draw!");
            }
            else if (computer == "PAPER")
            {
              Console.WriteLine("You lose!");
            }
            else
            {
              Console.WriteLine("You win!");
            }

            break;

          case "PAPER":
            if (computer == "ROCK")
            {
              Console.WriteLine("You win!");
            }
            else if (computer == "PAPER")
            {
              Console.WriteLine("it's a draw");
            }
            else
            {
              Console.WriteLine("You lose!");
            }

            break;
          case "SCISSOR":
            if (computer == "ROCK")
            {
              Console.WriteLine("You lose!");
            }
            else if (computer == "PAPER")
            {
              Console.WriteLine("You win!");
            }
            else
            {
              Console.WriteLine("it's a draw");
            }

            break;
        }
        Console.WriteLine("Would you like to play a again? (y/n)");
        answer = Console.ReadLine();
        answer = answer.ToUpper();

        if (answer == "Y")
        {
          playAgain = true;
        }
        else if (answer == "N")
        {
          playAgain = false;
        }
      }
      Console.WriteLine("Thanks for playing!");


      String Birthdayname = "Bro";
      int Birthdayage = 21;
      SingHappyBirthday(Birthdayname, Birthdayage);
    }

    static void SingHappyBirthday(String birthdayBoy, int yearsOld)
    {
      Console.WriteLine("Happy birthday to you!");
      Console.WriteLine("Happy birthday to you!");
      Console.WriteLine("Happy birthday dear!" + birthdayBoy );
      Console.WriteLine("You are"  + yearsOld + " years old!");
    }
  }
}