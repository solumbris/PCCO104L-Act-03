using System;

class Program {
  public static void Main (string[] args) {
    string phrase;
    do
      {
        Console.Write("Enter something: ");
        phrase = Console.ReadLine();
        Console.WriteLine(phrase);
      }
    while (phrase != "exit");
    Console.WriteLine("Closing program...");
  }
}