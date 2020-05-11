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
            Console.WriteLine("");
            Console.WriteLine("Hello and welcome to our magnificent menagerie!");
            Console.WriteLine("");
            Console.WriteLine("May we introduce a fine bunch of animals for you?");
            Console.WriteLine("y = Yes, please! n = Not right now, thank you!");
            string input = Console.ReadLine();
            try // this is unnecessary
            {
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
            }

            catch // since we never seem to end up here
            {
                Console.WriteLine("Apologies, the instructions maybe weren't quite clear! Please choose yes (y) or no (n)");
                input = Console.ReadLine();
            }

            Console.WriteLine("Which animal would you like to meet?");
            Console.WriteLine("b = bird d = dog c = cat p = pig r = rat B = bear T = tiger W = wolf");
            string input3 = Console.ReadLine();
            Regex regex = new Regex("^(b|d|c|p|r|B|T|W)$");

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
                    Console.WriteLine("Unfortunately that option isn't available. Please choose one of the following: b = bird d = dog c = cat p = pig r = rat B = bear T = tiger W = wolf");
                    input3 = Console.ReadLine();
                }
            }

            if (input3 == "b")
            {
                ITame tame = new Bird();
            }

            while (true)
            {
                Console.WriteLine("What would you like to do?");
                Regex regex2 = new Regex("^(b|d|c|p|r)$"); // if user chooses a tame animal
                if (regex2.IsMatch(input3))
                {
                    Console.WriteLine("f = Give the animal some food.");
                    Console.WriteLine("n = Give a name to the animal.");
                    Console.WriteLine("c = Call the animal to you.");
                    Console.WriteLine("t = Talk to the animal.");
                    Console.WriteLine("q = quit");

                }
                Regex regex3 = new Regex("^(B|T|W)$"); // if user chooses a wild animal
                if (regex3.IsMatch(input3))
                {
                    Console.WriteLine("h = See the animal hunt.");
                    Console.WriteLine("s = Hear what the animal sounds like.");
                    Console.WriteLine("q = quit");

                }

                string input4 = Console.ReadLine();

                if (input4 == "q")
                {
                    Console.WriteLine("We're sorry to see you go! Please do stop by another time!");
                    break;
                }

                Regex regex4 = new Regex("^(f|n|c|t|h|s|)$");

                if (!regex4.IsMatch(input4))
                {
                    Console.WriteLine("Please choose one of the options above!");
                }

                else if (regex4.IsMatch(input4))
                {

                }

            }
        }

    }


}

