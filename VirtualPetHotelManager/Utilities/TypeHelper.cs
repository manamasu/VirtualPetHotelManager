namespace VirtualPetHotelManager.Utilities;

public static class TypeHelper
{
    public static void TypeWriterEffect(string s, int ms, ConsoleColor color = ConsoleColor.White)
    {
        Console.ForegroundColor = color;
        foreach (char c in s)
        {
            Console.Write(c);
            Thread.Sleep(ms);
        }
        Thread.Sleep(200);
        Console.WriteLine();
        Console.WriteLine();
    }
}
