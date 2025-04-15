using VirtualPetHotelManager.Enums;

namespace VirtualPetHotelManager.Models
{
    public class Pet
    {
        public required string PetName { get; set; }
        public virtual HungerLevel HungerLevel { get; set; }
        public virtual MoodLevel MoodLevel { get; set; }
    }
}
