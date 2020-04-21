  using System;
using Animals;

namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Wolf wolfie = new Wolf();
      Console.WriteLine(wolfie.Hunt());
    }
  }
}