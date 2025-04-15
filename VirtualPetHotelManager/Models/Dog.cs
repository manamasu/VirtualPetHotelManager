using VirtualPetHotelManager.Enums;

namespace VirtualPetHotelManager.Models
{
    internal class Dog : Pet
    {
        public required override string PetName { get; set; }
        public override HungerLevel HungerLevel { get; set; }
        public override MoodLevel MoodLevel { get; set; }
        public override int EnergyLevel { get; set; }
        public Dog(string petName) : base(petName) { }

    }
}
