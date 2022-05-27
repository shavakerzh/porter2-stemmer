using System;

namespace Porter2Stemmer
{
    internal static class StringExtensions
    {
        public static bool StartsWithOrdinal(this string str, string value)
        {
            return str.StartsWith(value, StringComparison.Ordinal);
        }

        public static bool EndsWithOrdinal(this string str, string value)
        {
            return str.EndsWith(value, StringComparison.Ordinal);
        }
    }
}
