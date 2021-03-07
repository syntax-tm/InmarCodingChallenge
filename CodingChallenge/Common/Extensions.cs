using System;

namespace CodingChallenge
{
    public static class Extensions
    {
        public static bool ContainsIgnoreCase(this string input, string other)
        {
            if (input == null)
            {
                return other == null;
            }

            return input.Contains(other, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
