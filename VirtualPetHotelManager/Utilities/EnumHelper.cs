namespace VirtualPetHotelManager.Utilities
{
    public static class EnumHelper
    {
        public static Enum GetRandomEnumValue<T>(T type) where T : Enum
        {
            if (t == null) throw new ArgumentNullException(nameof(type));
            return Enum.GetValues()          // get values from Type provided
                .OfType<Enum>()               // casts to Enum
                .OrderBy(e => Guid.NewGuid()) // mess with order of results
                .FirstOrDefault();            // take first item in result
        }
    }
}
