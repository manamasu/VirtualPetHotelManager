using System.Text.Json;
using VirtualPetHotelManager.Models;

namespace VirtualPetHotelManager.Utilities
{
    public static class JsonFileHelper
    {
        private const string FileName = "VirtualPetSaveFile.json";
        private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, FileName);
        public static void SaveToJSON<T>(T model) where T : Pet
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(model, options);

            File.WriteAllText(FileName, jsonString);

            Console.WriteLine($"VirtualPet: ${model.GetType()} has been saved at: {FilePath}");

            Console.WriteLine(jsonString);
        }

        public static T LoadFromJson<T>()
        {
            if (!File.Exists(FilePath)) throw new FileNotFoundException("Save file not found.");
            string json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<T>(json)!;
        }
    }
}
