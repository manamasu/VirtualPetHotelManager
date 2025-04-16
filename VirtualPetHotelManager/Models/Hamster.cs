namespace VirtualPetHotelManager.Models
{
    internal class Hamster : Pet
    {
        public Hamster(string petName) : base(petName) { }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
