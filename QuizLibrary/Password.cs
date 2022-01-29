using System;

namespace QuizLibrary
{
    public static class Password
    {
        public const int MinLength = 5;
        public const int MaxLength = 30;

        public static bool Validate(String password)
        {
            if (password.Length < MinLength || password.Length > MaxLength)
                return false;

            if (password.Contains(" "))
                return false;

            bool hasLetters = false;
            bool hasDigits = false;
            foreach (char symbol in password)
            {
                if (char.IsLetter(symbol))
                    hasLetters = true;
                if (char.IsDigit(symbol))
                    hasDigits = true;
            }

            if (!hasLetters || !hasDigits)
                return false;

            return true;
        }
    }
}
