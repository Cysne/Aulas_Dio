using static System.Console;
using POO.Entities;
class program
{

  static void Main(string[] args)
  {

    Knight arus = new Knight("Arus", 23, "Knight");
    Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
    Ninja ninja = new Ninja("Naruto", 23, "Ninja");
    Villain villain = new Villain("Maleficos", 60, "Black Wizard");

    Console.WriteLine(arus.Attack());
    Console.WriteLine(wizard.Attack(7));
    Console.WriteLine(ninja.Attack(7));
    Console.WriteLine(villain.Attack(2));
  }
}