using System;
using NUnit.Framework;
using Animals;

public class PetTests
{
  [Test]
  public void DogTalkToOwnerReturnsWoof()
  {
    string expected = "Woof!";
    string actual = new Dog().TalkToOwner();

    Assert.AreEqual(expected, actual, "Dog should say Woof!");
  }

  [Test]
  public void RatTalkToOwnerReturnsSqueek()
  {
    string expected = "Squeek!";
    string actual = new Rat().TalkToOwner();

    Assert.AreEqual(expected, actual, "Rat should say Squeek!");
  }
  [Test]
  public void CatTalkToOwnerReturnsMeow()
  {
    string expected = "Meow!";
    string actual = new Cat().TalkToOwner();

    Assert.AreEqual(expected, actual, "Cat should say Meow!");
  }
  [Test]
  public void BirdTalkToOwnerReturnsTweet()
  {
    string expected = "Tweet!";
    string actual = new Bird().TalkToOwner();

    Assert.AreEqual(expected, actual, "Bird should say Tweet!");
  }
  [Test]
  public void PigTalkToOwnerReturnsOink()
  {
    string expected = "Oink!";
    string actual = new Pig().TalkToOwner();

    Assert.AreEqual(expected, actual, "Pig should say Oink Oink!");
  }
}
