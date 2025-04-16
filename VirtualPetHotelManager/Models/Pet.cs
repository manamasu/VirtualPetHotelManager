using VirtualPetHotelManager.Enums;
using VirtualPetHotelManager.Interfaces;
using static VirtualPetHotelManager.Utilities.EnumHelper;

namespace VirtualPetHotelManager.Models
{
    public abstract class Pet : IPet
    {
        public string PetName { get; set; }
        public virtual HungerLevel HungerLevel { get; set; }
        public virtual MoodLevel MoodLevel { get; set; }
        public virtual int EnergyLevel { get; set; }

        private readonly Random _random = new();

        protected Pet(string petname)
        {
            PetName = petname;
            HungerLevel = GetRandomEnumValue<HungerLevel>(_random);
            MoodLevel = GetRandomEnumValue<MoodLevel>(_random);
            EnergyLevel = 80;
        }


        public void Feed()
        {
            throw new NotImplementedException();
        }

        public virtual string GetStatus(Pet pet)
        {
            return $"{pet.PetName} is ${pet.MoodLevel}, is ${pet.HungerLevel} and has ${pet.EnergyLevel}% Energy left.";
        }

        public abstract void MakeSound();


        public void Play()
        {
            throw new NotImplementedException();
        }

        public void Rest()
        {
            throw new NotImplementedException();
        }

        public void Walk()
        {
            throw new NotImplementedException();
        }
    }
}
