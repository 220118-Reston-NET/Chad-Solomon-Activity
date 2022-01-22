using System;
using System.Collections;
using MenuSelection;
namespace DataCollection
{

    public class Data
    {
        List<string> log = new List<string>();
        public void addAdventureLog(string choice)
        {

            // ArrayList log = new ArrayList();
            bool isEmpty = !log.Any();
            if (isEmpty)
            {
                log.Add(choice);
                Console.WriteLine(log[0]);
            }
            else if (!isEmpty)
            {
                log.Add(choice);
                Console.WriteLine(log[1]);
            }
            else if (!isEmpty)
            {

                log.Add(choice);
                Console.WriteLine(log[2]);
            }
        }

        public void removeAdventureLog(string word)
        {
            Console.WriteLine(log.Remove(word));
        }

        public void displayAdventureLog()
        {
            for (int i = 0; i < log.Count; i++)
            {
                Console.WriteLine(log[i]);
            }

        }

        public void searchAdventureLog(string search)
        {
            for (int i = 0; i < log.Count;)
            {
                Console.WriteLine(log.IndexOf(search));
            }

        }
    }
}
// Create a new C# file inside your menu project called Data
// Create a Data class that will hold a collection of something for your menu
// Add any class members (methods, constructors, properties, fields, etc.) to Data class that you think will be useful to accomplish the following functions
// Add function to Menu to add elements to a collection
// This function might look different depending on what theme you created for your menu app
// Ex: If it is a shopping app then maybe a cart system would make the most sense
// Add function to Menu to display all the current elements to a collection
// Add function to Menu to remove certain elements to a collection
// Add function to Menu to search for a certain element in a collection
// Look into C# documentation of what methods are available for you in the collection that you are using that might help you find certain elements
// You can also just create your own coding logic to find certain elements in a collection
// If no element exist, be sure to tell the user that the element was not found.
