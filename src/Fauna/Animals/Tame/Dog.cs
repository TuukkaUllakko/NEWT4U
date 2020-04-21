  using System;

namespace Animals
{
  public class Dog : Animal, ITame
  {
    public string TalkToOwner()
    {
      return "Woof!";
    }
    public override string MakeSound()
    {
      return "Woof!";
    }
    public string ComeHere()
    {
      return " came to the owner.";
    }
  }
}