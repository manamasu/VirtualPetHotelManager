using VirtualPetHotelManager.Enums;

namespace VirtualPetHotelManager.Models
{
    internal class Dog : Pet
    {
        public Dog(string petName) : base(petName) { }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }

    }
}
