namespace MenuSelection
{


    public class Menu
    {


        public void foodMenu()
        {

            Console.WriteLine("Are you hungry?");
            Console.WriteLine("Type yes or no");
            string hungry = Consoel.ReadLine();

            while (hungry == "yes")
            {

                Console.WriteLine("What type of food would you like based on culture?");
                string culture = Console.ReadLine();

                if (culture == "Mexican")
                {
                    Console.WriteLine("Tonight you will be having tacos on corn tortillas");
                    Console.WriteLine("Would you like gaucamole?");
                    Console.WriteLine("Type yes or no");
                    string guac = Console.ReadLine();
                    if (guac == "yes")
                    {
                        Console.WriteLine("Excellent choice!");
                    }
                    else if (guac == "no")
                    {
                        Console.WriteLine("weirdo!");
                    }

                }

            }

        }
    }
}
