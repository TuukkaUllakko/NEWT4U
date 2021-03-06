using System;
using System.Text.RegularExpressions;

namespace Animals
{
    public class UI
    {
        public UI()
        {
        }
        public void Start()
        {
            /*Console.WriteLine("");
            Console.WriteLine("Hello and welcome to our magnificent menagerie!");
            Console.WriteLine("");
            Console.WriteLine("May we introduce a fine bunch of animals for you?");
            Console.WriteLine("y = Yes, please! n = Not right now, thank you!");
            string input = Console.ReadLine();
                while (!(input == "y") && !(input == "n"))
                {
                    Console.WriteLine("Please choose yes (y) or no (n)");
                    input = Console.ReadLine();
                }
                if (input == "n")
                {
                    Console.WriteLine("");
                    Console.WriteLine("You're welcome to visit us at a more convenient time!");
                    System.Environment.Exit(0);
                }
                else if (input == "y")
                {
                    Console.WriteLine("");
                    Console.WriteLine("Splendid! We have for you some tame animals (bird, dog, cat, pig and rat)");
                    Console.WriteLine("... as well as some wild ones (bear, tiger and wolf).");
                    Console.WriteLine("");
                }

            Console.WriteLine("Which animal would you like to meet?");
            Console.WriteLine("1 = bird 2 = dog 3 = cat 4 = pig 5 = rat 6 = bear 7 = tiger 8 = wolf");
            string input3 = Console.ReadLine();
            Regex regex = new Regex("^(1|2|3|4|5|6|7|8)$");

            while (true)
            {
                if (regex.IsMatch(input3))
                {
                    Console.WriteLine("");
                    Console.WriteLine("An excellent choice!");
                    Console.WriteLine("");
                    break;
                }
                else
                {
                    Console.WriteLine("Unfortunately that option isn't available. Please choose one of the following: 1 = bird 2 = dog 3 = cat 4 = pig 5 = rat 6 = bear 7 = tiger 8 = wolf");
                    input3 = Console.ReadLine();
                }
            }

            if (input3 == "1")
            {
                ITame bird = new Bird();
            }

            while (true)
            {
                Console.WriteLine("What would you like to do?");
                Regex regex2 = new Regex("^(0|1|2|3|4)$"); // if user chooses a tame animal
                if (regex2.IsMatch(input3))
                {
                    Console.WriteLine("0 = Quit");
                    Console.WriteLine("1 = Give the animal some food.");
                    Console.WriteLine("2 = Give a name to the animal.");
                    Console.WriteLine("3 = Call the animal to you.");
                    Console.WriteLine("4 = Talk to the animal.");

                }
                Regex regex3 = new Regex("^(5|6|7)$"); // if user chooses a wild animal
                if (regex3.IsMatch(input3))
                {
                    Console.WriteLine("0 = Quit");
                    Console.WriteLine("1 = See the animal hunt.");
                    Console.WriteLine("2 = Hear what the animal sounds like.");

                }

                string input4 = Console.ReadLine();

                if (input4 == "0")
                {
                    Console.WriteLine("We're sorry to see you go! Please do stop by another time!");
                    break;
                }

                Regex regex4 = new Regex("^(1|2|3|4|)$");

                if (!regex4.IsMatch(input4))
                {
                    Console.WriteLine("Please choose one of the options above!");
                }

                else if (regex4.IsMatch(input4))
                {
                    if (Convert.ToInt32(input4) == 1)
                    {

                    }
                    if (Convert.ToInt32(input4) == 2)
                    {
                        
                    }
                    if (Convert.ToInt32(input4) == 3)
                    {
                        
                    }
                    if (Convert.ToInt32(input4) == 4)
                    {
                        
                    }
                    if (Convert.ToInt32(input4) == 5)
                    {
                        
                    }
                }*/

            Console.WriteLine("");
            Console.WriteLine("Hello and welcome to our magnificent menagerie!");
            Console.WriteLine("");
            Console.WriteLine("May we introduce a fine bunch of animals for you?");
            Console.WriteLine("y = Yes, please! n = Not right now, thank you!");
            string input = Console.ReadLine();

            while (!(input == "y") && !(input == "n"))
            {
                Console.WriteLine("Please choose yes (y) or no (n)");
                input = Console.ReadLine();
            }
            if (input == "n")
            {
                Console.WriteLine("");
                Console.WriteLine("You're welcome to visit us at a more convenient time!");
                System.Environment.Exit(0);
            }
            if (input == "y")
            {
                Console.WriteLine("");
                Console.WriteLine("Splendid! We have for you some tame animals (bird, dog, cat, pig and rat)");
                Console.WriteLine("... as well as some wild ones (bear, tiger and wolf).");
                Console.WriteLine("");
            }

            while (true)
            {
                Console.WriteLine("Which animal would you like to meet?");
                Console.WriteLine(); // added an empty line
                Console.WriteLine("0 = quit\n1 = Bird\n2 = Cat\n3 = Dog\n4 = Pig\n5 = Rat\n6 = Bear\n7 = Tiger\n8 = Wolf"); // changed Quit to quit 
                string whichAnimal = Console.ReadLine();
                Regex regexAnimal = new Regex("^(0|1|2|3|4|5|6|7|8|)$");
                if (!regexAnimal.IsMatch(whichAnimal))
                {
                    Console.WriteLine();
                    Console.WriteLine("Please choose one of the options above!");
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(3000);
                    continue;
                }

                if (whichAnimal == "0")
                {
                    Console.WriteLine();
                    Console.WriteLine("We're sorry to see you go! Please do stop by another time!");
                    System.Threading.Thread.Sleep(3000);
                    break;
                }

                if (whichAnimal == "1")
                {
                    Bird bird = new Bird();
                    while (true)
                    {
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine(); // added an empty line to all

                        Console.WriteLine("1 = Go back.");
                        Console.WriteLine("2 = Give the animal some food.");
                        Console.WriteLine("3 = Give a name to the animal.");
                        Console.WriteLine("4 = Call the animal to you.");
                        Console.WriteLine("5 = Talk to the animal.");
                        string toDo = Console.ReadLine();

                        if (toDo != "1" && toDo != "2" && toDo != "3" && toDo != "4" && toDo != "5")
                        {
                            Console.WriteLine("Please choose one of the options above!");
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }

                        if (toDo == "1")
                        {
                            break;
                        }
                        if (toDo == "2")
                        {
                            Console.WriteLine();
                            bird.Eat();
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }
                        if (toDo == "3")
                        {
                            Console.WriteLine();
                            Console.WriteLine("What would you like to call the animal?");
                            string name = Console.ReadLine();
                            bird.GiveName(name);
                            Console.WriteLine();
                        }
                        if (toDo == "4")
                        {
                            Console.WriteLine();
                            Console.WriteLine(bird.ComeHere());
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }
                        if (toDo == "5")
                        {
                            Console.WriteLine();
                            Console.WriteLine("What do you want to say to the animal?");
                            string something = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine(bird.MakeSound());
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }
                    }
                }
                if (whichAnimal == "2")
                {
                    Cat cat = new Cat();
                    while (true)
                    {
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine();
                        Console.WriteLine("1 = Go back.");
                        Console.WriteLine("2 = Give the animal some food.");
                        Console.WriteLine("3 = Give a name to the animal.");
                        Console.WriteLine("4 = Call the animal to you.");
                        Console.WriteLine("5 = Talk to the animal.");
                        string toDo = Console.ReadLine();

                        if (toDo != "1" && toDo != "2" && toDo != "3" && toDo != "4" && toDo != "5")
                        {
                            Console.WriteLine("Please choose one of the options above!");
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }

                        if (toDo == "1")
                        {
                            break;
                        }
                        if (toDo == "2")
                        {
                            Console.WriteLine();
                            cat.Eat();
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }
                        if (toDo == "3")
                        {
                            Console.WriteLine();
                            Console.WriteLine("What would you like to call the animal?");
                            string name = Console.ReadLine();
                            cat.GiveName(name);
                            Console.WriteLine();
                        }
                        if (toDo == "4")
                        {
                            Console.WriteLine();
                            Console.WriteLine(cat.ComeHere());
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }
                        if (toDo == "5")
                        {
                            Console.WriteLine();
                            Console.WriteLine("What do you want to say to the animal?");
                            string something = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine(cat.MakeSound());
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }
                    }
                }
                if (whichAnimal == "3")
                {
                    Dog dog = new Dog();
                    while (true)
                    {
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine();
                        Console.WriteLine("1 = Go back.");
                        Console.WriteLine("2 = Give the animal some food.");
                        Console.WriteLine("3 = Give a name to the animal.");
                        Console.WriteLine("4 = Call the animal to you.");
                        Console.WriteLine("5 = Talk to the animal.");
                        string toDo = Console.ReadLine();

                        if (toDo != "1" && toDo != "2" && toDo != "3" && toDo != "4" && toDo != "5")
                        {
                            Console.WriteLine("Please choose one of the options above!");
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }

                        if (toDo == "1")
                        {
                            break;
                        }
                        if (toDo == "2")
                        {
                            Console.WriteLine();
                            dog.Eat();
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }
                        if (toDo == "3")
                        {
                            Console.WriteLine();
                            Console.WriteLine("What would you like to call the animal?");
                            string name = Console.ReadLine();
                            dog.GiveName(name);
                            Console.WriteLine();
                        }
                        if (toDo == "4")
                        {
                            Console.WriteLine();
                            Console.WriteLine(dog.ComeHere());
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }
                        if (toDo == "5")
                        {
                            Console.WriteLine();
                            Console.WriteLine("What do you want to say to the animal?");
                            string something = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine(dog.MakeSound());
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }
                    }
                }
                if (whichAnimal == "4")
                {
                    Pig pig = new Pig(); //CHANGE EVERYTHING FROM DOG TO PIG HERE (NOT CHANGE ALL OCCURRENCES)
                    while (true)
                    {
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine();
                        Console.WriteLine("1 = Go back.");
                        Console.WriteLine("2 = Give the animal some food.");
                        Console.WriteLine("3 = Give a name to the animal.");
                        Console.WriteLine("4 = Call the animal to you.");
                        Console.WriteLine("5 = Talk to the animal.");
                        string toDo = Console.ReadLine();

                        if (toDo != "1" && toDo != "2" && toDo != "3" && toDo != "4" && toDo != "5")
                        {
                            Console.WriteLine("Please choose one of the options above!");
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }

                        if (toDo == "1")
                        {
                            break;
                        }
                        if (toDo == "2")
                        {
                            Console.WriteLine();
                            pig.Eat();
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }
                        if (toDo == "3")
                        {
                            Console.WriteLine();
                            Console.WriteLine("What would you like to call the animal?");
                            string name = Console.ReadLine();
                            pig.GiveName(name);
                            Console.WriteLine();
                        }
                        if (toDo == "4")
                        {
                            Console.WriteLine();
                            Console.WriteLine(pig.ComeHere());
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }
                        if (toDo == "5")
                        {
                            Console.WriteLine();
                            Console.WriteLine("What do you want to say to the animal?");
                            string something = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine(pig.MakeSound());
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }
                    }
                }
                if (whichAnimal == "5")
                {
                    Rat rat = new Rat(); //CHANGE EVERYTHING FROM DOG TO RAT HERE (NOT CHANGE ALL OCCURRENCES)
                    while (true)
                    {
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine();
                        Console.WriteLine("1 = Go back.");
                        Console.WriteLine("2 = Give the animal some food.");
                        Console.WriteLine("3 = Give a name to the animal.");
                        Console.WriteLine("4 = Call the animal to you.");
                        Console.WriteLine("5 = Talk to the animal.");
                        string toDo = Console.ReadLine();

                        if (toDo != "1" && toDo != "2" && toDo != "3" && toDo != "4" && toDo != "5")
                        {
                            Console.WriteLine("Please choose one of the options above!");
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }

                        if (toDo == "1")
                        {
                            break;
                        }
                        if (toDo == "2")
                        {
                            Console.WriteLine();
                            rat.Eat();
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }
                        if (toDo == "3")
                        {
                            Console.WriteLine();
                            Console.WriteLine("What would you like to call the animal?");
                            string name = Console.ReadLine();
                            rat.GiveName(name);
                            Console.WriteLine();
                        }
                        if (toDo == "4")
                        {
                            Console.WriteLine();
                            Console.WriteLine(rat.ComeHere());
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }
                        if (toDo == "5")
                        {
                            Console.WriteLine();
                            Console.WriteLine("What do you want to say to the animal?");
                            string something = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine(rat.MakeSound());
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }
                    }
                }
                if (whichAnimal == "6")
                {
                    Bear bear = new Bear();
                    while (true)
                    {
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine();
                        Console.WriteLine("1 = Go back.");
                        Console.WriteLine("2 = Watch the animal hunt");
                        Console.WriteLine("3 = Hear the sound of the animal");
                        string toDo = Console.ReadLine();

                        if (toDo != "1" && toDo != "2" && toDo != "3")
                        {
                            Console.WriteLine("Please choose one of the options above!");
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }

                        if (toDo == "1")
                        {
                            break;
                        }
                        if (toDo == "2")
                        {
                            Console.WriteLine();
                            Console.WriteLine(bear.Hunt());
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }
                        if (toDo == "3")
                        {
                            Console.WriteLine();
                            Console.WriteLine(bear.MakeSound());
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }
                    }
                }
                if (whichAnimal == "7")
                {
                    Tiger tiger = new Tiger(); //CHANGE EVERYTHING FROM BEAR TO TIGER HERE (NOT CHANGE ALL OCCURRENCES)
                    while (true)
                    {
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine();
                        Console.WriteLine("1 = Go back.");
                        Console.WriteLine("2 = Watch the animal hunt");
                        Console.WriteLine("3 = Hear the sound of the animal");
                        string toDo = Console.ReadLine();

                        if (toDo != "1" && toDo != "2" && toDo != "3")
                        {
                            Console.WriteLine("Please choose one of the options above!");
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }

                        if (toDo == "1")
                        {
                            break;
                        }
                        if (toDo == "2")
                        {
                            Console.WriteLine();
                            Console.WriteLine(tiger.Hunt());
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }
                        if (toDo == "3")
                        {
                            Console.WriteLine();
                            Console.WriteLine(tiger.MakeSound());
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }
                    }
                }
                if (whichAnimal == "8")
                {
                    Wolf wolf = new Wolf(); //CHANGE EVERYTHING FROM BEAR TO WOLF HERE (NOT CHANGE ALL OCCURRENCES)
                    while (true)
                    {
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine();
                        Console.WriteLine("1 = Go back.");
                        Console.WriteLine("2 = Watch the animal hunt.");
                        Console.WriteLine("3 = Hear the sound of the animal.");
                        string toDo = Console.ReadLine();

                        if (toDo != "1" && toDo != "2" && toDo != "3")
                        {
                            Console.WriteLine("Please choose one of the options above!");
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }

                        if (toDo == "1")
                        {
                            break;
                        }
                        if (toDo == "2")
                        {
                            Console.WriteLine();
                            Console.WriteLine(wolf.Hunt());
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }
                        if (toDo == "3")
                        {
                            Console.WriteLine();
                            Console.WriteLine(wolf.MakeSound());
                            Console.WriteLine();
                            System.Threading.Thread.Sleep(3000);
                        }

                    }
                }
            }

        }
    }
}

