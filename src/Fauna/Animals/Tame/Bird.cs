namespace Animals
{
  public class Bird : ITame
  {
    public string TalkToOwner()
    {
      return "Tweet!";
    } 
    
    public string MakeSound()
  {
     return "Tweet!";
  }
  public string ComeHere()
  {
      return "Bird came to the owner";
  }

  }

}