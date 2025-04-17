using VirtualPetHotelManager.Models;
using static VirtualPetHotelManager.Menus.ConfirmationMenu;
using static VirtualPetHotelManager.Utilities.TypeHelper;
using static VirtualPetHotelManager.Utilities.JsonFileHelper;

namespace VirtualPetHotelManager.Menus
{
    public static class MainMenu
    {
        public static void Menu()
        {
            string welcomeMessage = "Welcome to your VirtualPetHotelManager!";

            TypeWriterEffect(welcomeMessage, 40);
            StartOptionMenu();

            bool showMenu = true;
            while (showMenu)
            {
                var keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        Console.WriteLine("Would you like to have a Cat?");
                        Console.WriteLine("Press Enter to confirm. Press Escape to go back to the MainMenu.");
                        var action = Console.ReadKey().Key;
                        if (action == ConsoleKey.Enter)
                        {
                            Console.Clear();
                            Console.WriteLine("Congratulations! You have a new cat.");
                            Console.WriteLine("Please enter a name for your pet: ");
                            string petName = "";


                            while (string.IsNullOrWhiteSpace(petName) && !ConfirmPetName(petName))
                            {
                                petName = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(petName))
                                {
                                    Console.WriteLine("You have to give your pet a name. Try again");
                                }
                                else
                                {
                                    ConfirmPetName(petName);
                                }
                            }

                            Cat cat = new(petName);
                            Console.WriteLine($"You have a new {cat.GetType().Name} with the name: {cat.PetName}. Congratulations!!!");
                            SaveToJSON(cat);
                            Thread.Sleep(8000);
                            Console.Clear();
                            StartOptionMenu();
                        }
                        else if (action == ConsoleKey.Escape)
                        {
                            Console.Clear();
                            StartOptionMenu();
                        }
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("hi from dog");
                        showMenu = false;
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("hi from hamster");
                        showMenu = false;
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine("hi from fish");
                        showMenu = false;
                        break;
                    case ConsoleKey.D5:
                        Console.Clear();
                        string gameRules = """
                            The Rules are simple: 

                            Choose a Pet and care about it. 
                            Make sure to give it food, play with your pet to keep it happy and 
                            let it rest to recharge its energy.
                            Aquire more pets by playing the game a certain amount of time.
                            Try everything out and have fun!
                            Navigate by pressing the instructed Numbers or Keys.
                            """;
                        TypeWriterEffect(gameRules, 40);
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("EXIT!!!");
                        showMenu = false;
                        break;
                }
            }

        }

        private static void StartOptionMenu()
        {
            Console.WriteLine("Start by pressing an option:");
            Console.WriteLine("1) Choose a Cat");
            Console.WriteLine("2) Choose a Dog");
            Console.WriteLine("3) Choose a Hamster");
            Console.WriteLine("5) Show Help");
            Console.WriteLine("Escape) Exit");
            Console.Write("\r\nSelect an option: ");
        }
    }
}
