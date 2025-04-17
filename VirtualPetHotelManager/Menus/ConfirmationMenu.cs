namespace VirtualPetHotelManager.Menus
{
    public static class ConfirmationMenu
    {
        public static bool ConfirmPetName(string petName)
        {
            if (string.IsNullOrWhiteSpace(petName))
            {
                return false;
            }

            Console.WriteLine($"Are you sure about your chosen pet name: \"{petName}\"?");
            Console.WriteLine("Press 1) Yes");
            Console.WriteLine("Press 2) No");

            while (true)
            {
                var keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                        return true;

                    case ConsoleKey.D2:
                        Console.WriteLine("\nAlright let's try again.");
                        return false;

                    default:
                        Console.WriteLine("\nInvalid input. Please press 1) or 2)");
                        break;
                }
            }
        }
    }
}
