using DataCollection;
namespace MenuSelection
{


    public class Adventure
    {


        public void adventureMenu()
        {
            Data adventure = new Data();
            //adventure.adventureLog();
            Console.WriteLine("Do you want to adventure?");
            Console.WriteLine("Type yes or no");
            string choice = Console.ReadLine();
            string repeat = "true";

            while (repeat == "true")
            {
                if (choice == "yes")
                {
                    //adventure.addAdventureLog(choice);
                    Console.WriteLine("Type the name of the character you would like to be!");
                    Console.WriteLine("1: Finn");
                    Console.WriteLine("2: Jake");
                    Console.WriteLine("3: Princess BubbleGum");
                    Console.WriteLine("4: Marceline");
                    Console.WriteLine("5: Adventure Log");
                    //Console.WriteLine();
                    string character = Console.ReadLine();
                    adventure.addAdventureLog(character);

                    if (character == "Finn")
                    {
                        Console.WriteLine("You have chosen to be Finn the human boy!");
                        //adventure.addAdventureLog(character);
                    }
                    else if (character == "Jake")
                    {
                        Console.WriteLine("You have chosen to be the magic dog Jake!");
                    }
                    else if (character == "Princess BubbleGum")
                    {
                        Console.WriteLine("You have chosen to be the leader of the cand people Princess BubbleGum!");
                    }
                    else if (character == "Marceline")
                    {
                        Console.WriteLine("You have chosen to be Marceline the vampire queen!");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                    }
                    else if (character == "Adventure Log")
                    {
                        Console.WriteLine("======Adventure Log Menu========");
                        Console.WriteLine("Select the number of the function you would like to perform!");
                        Console.WriteLine("1: Remove from Adventure Log");
                        Console.WriteLine("2: Display Adventure Log");
                        Console.WriteLine("3: Search through Adventure Log");
                        int advLog = Convert.ToInt32(Console.ReadLine());

                        if (advLog == 1)
                        {
                            Console.WriteLine("What word would you like to remove from the Log?");
                            string word = Console.ReadLine();
                            adventure.removeAdventureLog(word);

                        }
                        else if (advLog == 2)
                        {
                            adventure.displayAdventureLog();

                        }
                        else if (advLog == 3)
                        {
                            Console.WriteLine("What element would you like to search for?");
                            string search = Console.ReadLine();
                            adventure.searchAdventureLog(search);
                        }
                    }

                    Console.WriteLine("Where would you like to adventure?");
                    Console.WriteLine("Type the name of the location you would like to adventure.");
                    Console.WriteLine("1: Nightosphere");
                    Console.WriteLine("2: Ice Kingdom");
                    Console.WriteLine("3: Fire Kingdom");
                    Console.WriteLine("4: Candy Kingdom");
                    string location = Console.ReadLine();
                    adventure.addAdventureLog(location);

                    if (location == "Nightosphere")
                    {
                        Console.WriteLine("Watch out for Hunson Abadeer!");
                        //adventure.addAdventureLog(location);
                    }
                    else if (location == "Ice Kingdom")
                    {
                        Console.WriteLine("The Ice King is a wacky wizard!");
                    }
                    else if (location == "Fire Kingdom")
                    {
                        Console.WriteLine("Maybe the Flame Princess will have a rap battle with you!");
                    }
                    else if (location == "Candy Kingdom")
                    {
                        Console.WriteLine("Everything is candy, but do not eat the candy people!");
                    }
                }
                else if (choice == "no")
                {
                    Console.WriteLine("Goodbye!");
                    repeat = "no";
                }




            }

        }

    }
}

