using System;
using System.Text.RegularExpressions;

namespace QuizLibrary
{
    public static class Username
    {
        public const int MinLength = 5;
        public const int MaxLength = 15;
        public const int CountSpecSymbols = 0;
        public const String SpecSymbols = @"[!,@,#,\$,%,\^,&,\*,?,-,.,~]";

        public static bool Validate(String username)
        {
            if (username.Length < MinLength || username.Length >= MaxLength)
                return false;

            if (username.Contains(" "))
                return false;

            if (Regex.Matches(username, SpecSymbols).Count > CountSpecSymbols)
                return false;

            return true;
        }
    }
}
