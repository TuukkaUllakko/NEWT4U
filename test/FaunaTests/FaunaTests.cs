using System;
using NUnit.Framework;
using Animals;

public class AnimalsTests
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

        Assert.AreEqual(expected, actual, "Pig should say Oink");
    }
    //Below tests for MakeSound()
    [Test]
    public void BirdMakeSound()
    {
        string expected = "Tweet!";
        string actual = new Bird().MakeSound();

        Assert.AreEqual(expected, actual, "Bird should say Tweet!");
    }
    [Test]
    public void CatMakeSound()
    {
        string expected = "Meow!";
        string actual = new Cat().MakeSound();

        Assert.AreEqual(expected, actual, "Cat should say Meow!");
    }
    [Test]
    public void DogMakeSound()
    {
        string expected = "Woof!";
        string actual = new Dog().MakeSound();

        Assert.AreEqual(expected, actual, "Dog should say Woof!");
    }
    [Test]
    public void PigMakeSound()
    {
        string expected = "Oink!";
        string actual = new Pig().MakeSound();

        Assert.AreEqual(expected, actual, "Pig should say Oink!");
    }
    [Test]
    public void RatMakeSound()
    {
        string expected = "Squeek!";
        string actual = new Rat().MakeSound();

        Assert.AreEqual(expected, actual, "Rat should say Squeek!");
    }
    [Test]
    public void BearMakeSound()
    {
        string expected = "Roar!";
        string actual = new Bear().MakeSound();

        Assert.AreEqual(expected, actual, "Bear should say Roar!");
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
        string actual = new Bird().ComeHere();
        string expected = actual.ToString();

        Assert.AreEqual(expected, actual, "ComeHere() doesn't work");
    }
    [Test]
    public void CatComeHereReturnString()
    {
        string actual = new Cat().ComeHere();
        string expected = actual.ToString();

        Assert.AreEqual(expected, actual, "ComeHere() doesn't work");
    }
    [Test]
    public void DogComeHereReturnString()
    {
        string actual = new Dog().ComeHere();
        string expected = actual.ToString();

        Assert.AreEqual(expected, actual, "ComeHere() doesn't work");
    }
    [Test]
    public void PigComeHereReturnString()
    {
        string actual = new Pig().ComeHere();
        string expected = actual.ToString();

        Assert.AreEqual(expected, actual, "ComeHere() doesn't work");
    }
    [Test]
    public void RatComeHereReturnString()
    {
        string actual = new Rat().ComeHere();
        string expected = actual.ToString();
        Assert.AreEqual(expected, actual, "ComeHere() doesn't work");
    }
    //Below are the Hunt() tests
    [Test]
    public void WolfHuntReturnString()
    {
        Wolf testObj = new Wolf();
        string actual = testObj.Hunt();
        string expected = typeof(Wolf).Name + " hunts &";

        StringAssert.StartsWith(expected, actual, "Hunt() doesn't work");
    }
    [Test]
    public void BearHuntReturnString()
    {
        Bear testObj = new Bear();
        string actual = testObj.Hunt();
        string expected = typeof(Bear).Name + " hunts &";

        StringAssert.StartsWith(expected, actual, "Hunt() doesn't work");
    }
    [Test]
    public void TigerHuntReturnString()
    {
        Tiger testObj = new Tiger();
        string actual = testObj.Hunt();
        string expected = typeof(Tiger).Name + " hunts &";

        StringAssert.StartsWith(expected, actual, "Hunt() doesn't work");
    }
    //Below are the GiveName() tests
    [Test]
    public void GiveNameChangesNameBird()
    {
        Bird bird = new Bird();
        string actual = bird.Name;

        bird.GiveName("Bob");

        string expected = bird.Name;

        Assert.AreNotEqual(expected, actual, "GiveName() should change name.");
    }
    [Test]
    public void GiveNameChangesNameCat()
    {
        Cat bird = new Cat();
        string actual = bird.Name;

        bird.GiveName("Bob");

        string expected = bird.Name;

        Assert.AreNotEqual(expected, actual, "GiveName() should change name.");
    }
    [Test]
    public void GiveNameChangesNameDog()
    {
        Dog bird = new Dog();
        string actual = bird.Name;

        bird.GiveName("Bob");

        string expected = bird.Name;

        Assert.AreNotEqual(expected, actual, "GiveName() should change name.");
    }
    [Test]
    public void GiveNameChangesNamePig()
    {
        Pig bird = new Pig();
        string actual = bird.Name;

        bird.GiveName("Bob");

        string expected = bird.Name;

        Assert.AreNotEqual(expected, actual, "GiveName() should change name.");
    }
    [Test]
    public void GiveNameChangesNameRat()
    {
        Rat bird = new Rat();
        string actual = bird.Name;

        bird.GiveName("Bob");

        string expected = bird.Name;

        Assert.AreNotEqual(expected, actual, "GiveName() should change name.");
    }
    //Below are the tests for the Eat() method
    [Test]

    public void EatIncreasesWeightBird()
    {
        Bird testObj = new Bird();
        int actual = testObj.weight;

        testObj.Eat();

        int expected = testObj.weight;

        Assert.AreEqual(expected, actual + 1, "Eat() should increase weight by 1");
    }
    public void EatIncreasesWeightCat()
    {
        Cat testObj = new Cat();
        int actual = testObj.weight;

        testObj.Eat();

        int expected = testObj.weight;

        Assert.AreEqual(expected, actual + 1, "Eat() should increase weight by 1");
    }
    public void EatIncreasesWeightDog()
    {
        Dog testObj = new Dog();
        int actual = testObj.weight;

        testObj.Eat();

        int expected = testObj.weight;

        Assert.AreEqual(expected, actual + 1, "Eat() should increase weight by 1");
    }
    public void EatIncreasesWeightPig()
    {
        Pig testObj = new Pig();
        int actual = testObj.weight;

        testObj.Eat();

        int expected = testObj.weight;

        Assert.AreEqual(expected, actual + 1, "Eat() should increase weight by 1");
    }
    public void EatIncreasesWeightRat()
    {
        Rat testObj = new Rat();
        int actual = testObj.weight;

        testObj.Eat();

        int expected = testObj.weight;

        Assert.AreEqual(expected, actual + 1, "Eat() should increase weight by 1");
    }
}
