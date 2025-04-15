namespace VirtualPetHotelManager.Interfaces
{
    public interface IPet
    {
        //Daily Care and Activities
        void Feed();
        void Play();
        void Walk();
        void Rest();

        //Behaviour Of Pet
        void MakeSound();

        //Display current condition of pet: e.g "<PetName> is <MoodLevel> and <HungerLevel>
        string GetStatus();
    }
}
