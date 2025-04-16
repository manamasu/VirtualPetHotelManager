namespace VirtualPetHotelManager.Utilities
{
    public static class EnumHelper
    {
        public static T GetRandomEnumValue<T>(Random random) where T : Enum
        {
            //values is an array of all the values in the enum
            var values = Enum.GetValues(typeof(T));

            return (T)values.GetValue(random.Next(values.Length))!;
        }
    }
}
