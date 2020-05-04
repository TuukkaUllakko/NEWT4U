  using System;
using Animals;

namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      /*Bird birdie = new Bird();
      Console.WriteLine(birdie.ComeHere());
     
      Wolf wolfie = new Wolf();
      Console.WriteLine(wolfie.Hunt());

      Bear teddy = new Bear();
      Console.WriteLine(teddy.Hunt());

      Console.WriteLine(birdie.Name);

      birdie.GiveName(Console.ReadLine());

      Console.WriteLine(birdie.Name); */

      Bear teddyBear = new Bear();
      Console.WriteLine(teddyBear.Hunt());
    }
  }
}