﻿namespace VirtualPetHotelManager.Models
{
    public class Cat : Pet
    {

        public Cat(string petName) : base(petName) { }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}
