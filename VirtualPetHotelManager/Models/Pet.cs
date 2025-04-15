using VirtualPetHotelManager.Enums;
using VirtualPetHotelManager.Interfaces;

namespace VirtualPetHotelManager.Models
{
    public class Pet : IPet
    {
        public required virtual string PetName { get; set; }
        public virtual HungerLevel HungerLevel { get; set; }
        public virtual MoodLevel MoodLevel { get; set; }
        public virtual int EnergyLevel { get; set; }

        protected Pet(string petname)
        {
            PetName = petname;
            HungerLevel = HungerLevel.Hungry;
            MoodLevel = MoodLevel.Relaxed;
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

        public virtual void MakeSound()
        {
            throw new NotImplementedException();
        }

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
