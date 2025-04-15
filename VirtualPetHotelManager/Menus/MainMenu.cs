using static VirtualPetHotelManager.Utilities.TypeHelper;

namespace VirtualPetHotelManager.Menus
{
    public static class MainMenu
    {
        public static void Menu()
        {
            string welcomeMessage = "Welcome to your VirtualPetHotelManager!";

            TypeWriterEffect(welcomeMessage, 40);

            Console.WriteLine("Start by pressing an option:");
            Console.WriteLine("1) Choose a Cat");
            Console.WriteLine("2) Choose a Dog");
            Console.WriteLine("3) Choose a Hamster");
            Console.WriteLine("4) Choose a Fish");
            Console.WriteLine("5) Show Help");
            Console.WriteLine("6) Exit");
            Console.Write("\r\nSelect an option: ");
            bool showMenu = true;
            while (showMenu)
            {
                var keyInfo = Console.ReadKey();
                switch (keyInfo.KeyChar)
                {
                    case '1':
                        Console.WriteLine("hi from cat");
                        showMenu = false;
                        break;
                    case '2':
                        Console.WriteLine("hi from dog");
                        showMenu = false;
                        break;
                    case '3':
                        Console.WriteLine("hi from hamster");
                        showMenu = false;
                        break;

                    case '4':
                        Console.WriteLine("hi from fish");
                        showMenu = false;
                        break;
                    case '5':
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
                    default:
                        Console.WriteLine("EXIT!!!");
                        showMenu = false;
                        break;
                }
            }

        }
    }
}
