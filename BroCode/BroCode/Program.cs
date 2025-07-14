using System;

namespace BroCode
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      int x;  //declaration
      x = 123; //initialisation

      int y = 321; //declaration +initialisation
      int z = x + y;

      int age = 21; // whole integer
      double height = 300.5; // decimal number
      bool alive = false;
      string name = "Bro";
      char symbol = '@';

      Console.WriteLine("Your name is " + name);
      Console.WriteLine("Your age is " + age);
      Console.WriteLine("Your height is " + height+"cm");
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

    }
  }
}