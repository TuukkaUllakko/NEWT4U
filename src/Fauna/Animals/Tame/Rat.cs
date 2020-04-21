using System;

namespace Animals
{
  public class Rat : Animal, ITame
  {
    public string TalkToOwner()
    {
      return "Squeek!";
    }
    public override string MakeSound()
    {
      return "Squeek!";
    }
    public string ComeHere()
    {
      return " came to the owner.";
    }
  }
}