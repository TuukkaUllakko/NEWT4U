  using System;
using Animals;

namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Bird birdie = new Bird("Lucy");
      Console.WriteLine(birdie.ComeHere());
     
      Wolf wolfie = new Wolf();
      Console.WriteLine(wolfie.Hunt());

      Bear teddy = new Bear();
      Console.WriteLine(teddy.Hunt());

    }
  }
}