using System;
using NUnit.Framework;
using Animals;

public class AnimalsTests
{
    [Test]
    public void DogTalkToOwnerReturnsWoof()
    {
        string expected = "Woof!";
        string actual = new Dog("Bobby").TalkToOwner();

        Assert.AreEqual(expected, actual, "Dog should say Woof!");
    }

    [Test]
    public void RatTalkToOwnerReturnsSqueek()
    {
        string expected = "Squeek!";
        string actual = new Rat("Robert").TalkToOwner();

        Assert.AreEqual(expected, actual, "Rat should say Squeek!");
    }
    [Test]
    public void CatTalkToOwnerReturnsMeow()
    {
        string expected = "Meow!";
        string actual = new Cat("Lucy").TalkToOwner();

        Assert.AreEqual(expected, actual, "Cat should say Meow!");
    }
    [Test]
    public void BirdTalkToOwnerReturnsTweet()
    {
        string expected = "Tweet!";
        string actual = new Bird("Hannah").TalkToOwner();

        Assert.AreEqual(expected, actual, "Bird should say Tweet!");
    }
    [Test]
    public void PigTalkToOwnerReturnsOink()
    {
        string expected = "Oink!";
        string actual = new Pig("Carol").TalkToOwner();

        Assert.AreEqual(expected, actual, "Pig should say Oink");
    }
    //Below tests for MakeSound()
    [Test]
    public void BirdMakeSound()
    {
        string expected = "Tweet!";
        string actual = new Bird("Hannah").MakeSound();

        Assert.AreEqual(expected, actual, "Bird should say Tweet!");
    }
    [Test]
    public void CatMakeSound()
    {
        string expected = "Meow!";
        string actual = new Cat("Hannah").MakeSound();

        Assert.AreEqual(expected, actual, "Cat should say Meow!");
    }
    [Test]
    public void DogMakeSound()
    {
        string expected = "Woof!";
        string actual = new Dog("Hannah").MakeSound();

        Assert.AreEqual(expected, actual, "Dog should say Woof!");
    }
    [Test]
    public void PigMakeSound()
    {
        string expected = "Oink!";
        string actual = new Pig("Hannah").MakeSound();

        Assert.AreEqual(expected, actual, "Pig should say Oink!");
    }
    [Test]
    public void RatMakeSound()
    {
        string expected = "Squeek!";
        string actual = new Rat("Hannah").MakeSound();

        Assert.AreEqual(expected, actual, "Rat should say Squeek!");
    }
    [Test]
    public void BearMakeSound()
    {
        string expected = "Growl!";
        string actual = new Bear().MakeSound();

        Assert.AreEqual(expected, actual, "Bear should say Growl!");
    }
    [Test]
    public void TigerMakeSound()
    {
        string expected = "Grrr!";
        string actual = new Tiger().MakeSound();

        Assert.AreEqual(expected, actual, "Tiger should say Grrr!");
    }
    [Test]
    public void WolfMakeSound()
    {
        string expected = "Howl!";
        string actual = new Wolf().MakeSound();

        Assert.AreEqual(expected, actual, "Wolf should say Howl!");
    }
    //Below tests for ComeHere()
    [Test]
    public void BirdComeHereReturnString()
    {
        string actual = new Bird("Hannah").ComeHere();
        string expected = actual.ToString();

        Assert.AreEqual(expected, actual, "ComeHere() doesn't work");
    }
    [Test]
    public void CatComeHereReturnString()
    {
        string actual = new Cat("Hannah").ComeHere();
        string expected = actual.ToString();

        Assert.AreEqual(expected, actual, "ComeHere() doesn't work");
    }
    [Test]
    public void DogComeHereReturnString()
    {
        string actual = new Dog("Hannah").ComeHere();
        string expected = actual.ToString();

        Assert.AreEqual(expected, actual, "ComeHere() doesn't work");
    }
    [Test]
    public void PigComeHereReturnString()
    {
        string actual = new Pig("Hannah").ComeHere();
        string expected = actual.ToString();

        Assert.AreEqual(expected, actual, "ComeHere() doesn't work");
    }
    [Test]
    public void RatComeHereReturnString()
    {
        string actual = new Rat("Carol").ComeHere();
        string expected = actual.ToString();
        //Hello

        Assert.AreEqual(expected, actual, "ComeHere() doesn't work");
    }
    //Below are the Hunt() tests
<<<<<<< HEAD
    [Test]
    public void WolfHuntReturnString()
    {
        string actual = new Wolf().Hunt();
        string expected = "Wolf hunts";

        Assert.AreEqual(expected, actual, "Hunt() doesn't work");
    }
    [Test]
    public void BearHuntReturnString()
    {
        string actual = new Bear().Hunt();
        string expected = "Bear hunts";

        Assert.AreEqual(expected, actual, "Hunt() doesn't work");
    }
    [Test]
    public void TigerHuntReturnString()
    {
        string actual = new Tiger().Hunt();
        string expected = "Tiger hunts";

        Assert.AreEqual(expected, actual, "Hunt() doesn't work");
    }
    
=======

>>>>>>> 9d22443395be7a49fc43e03eec53c1e82fe26fb5
}
