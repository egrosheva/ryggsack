using System;

namespace ryggsackvektor
{
    class Program
    {
        static void Main(string[] args)
        {
            //menuLoop is a bool variable initialized with true used by the while loop,when set to false will stop the while loop
            bool menuLoop = true;
            //userChoice is an integer variable initilized with zero will store user's choice in menu
            int userChoice = 0;
            //ryggsack array of 5 elements, stores user's items
            string[] ryggsack = new string[5];
            //founditem bool variable initialized with false will be true only if item is found
            bool founditem = false;


            while (menuLoop == true)
            {
                //print the menu options
                Console.WriteLine("Välkommen till rygsäcken!");
                Console.WriteLine("[1] Lägg till fem föremål");
                Console.WriteLine("[2] Skriv ut innehållet");
                Console.WriteLine("[3] Söka ett föremål");
                Console.WriteLine("[4] Avsluta");
                Console.WriteLine("Välj:");
                //read the user's choice and tryparse until user enters valid integer value
                while (Int32.TryParse(Console.ReadLine(), out userChoice) != true) ;
                //userChoice = Console.ReadLine();
                //print the userChoice
                Console.WriteLine("userChoice: " + userChoice);
                //switch on different cases for the userChoice
                switch (userChoice)
                {
                    //in case userchoice is 1 add 5 items to Ryggsack
                    case 1:
                        //add items to ryggsack

                        for (int index = 0; index < ryggsack.Length; index++)
                        {
                            Console.WriteLine("New item in ryggsäck position " + index);
                            //read new item and save it in temporary variable, convert it to String and save it to ryggsackItem
                            ryggsack[index] = Console.ReadLine();
                        }

                        break;
                    case 2:
                        //print the items in ryggsack
                        for (int index = 0; index < ryggsack.Length; index++)
                        {
                           Console.WriteLine("item " + index + " in ryggsäck: " + ryggsack[index]);
                        }
                        break;
                    case 3:
                        //searcheditem string variable will hold serarched value in ryggsack
                        String searcheditem;
                        //search Item in ryggsack
                        Console.WriteLine("Enter searched value:");
                        searcheditem = Convert.ToString(Console.ReadLine());
                        for (int index = 0; index < ryggsack.Length; index++)
                        {
                            if (ryggsack[index] == searcheditem)
                            {
                                founditem = true;
                            }

                        }
                        if (founditem == true)
                        {
                            Console.WriteLine("Ryggsäck element " + searcheditem + " found!");
                            founditem = false;
                        }
                        else
                        {
                            Console.WriteLine("Ryggsäck element not found!");

                        }
                        break;
                    case 4:
                        //set the value of menuLoop variable to false
                        menuLoop = false;
                        break;
                    default:
                        //print warning message for any value of userChoice other than 1, 2, 3, 4
                        Console.WriteLine("Non valid choice. Try again.");
                        break;
                }

            }
        }

    }
}
