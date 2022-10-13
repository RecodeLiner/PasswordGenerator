using System;

namespace PasswordGenerator
{
    public class Password
    {
        private static readonly string[] Symbols = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "[", "]", ";", "'", ".", "/", "{", "}", ":", "?", "<", ">", "|", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "№", "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m", "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M" };

        private readonly Random _random;
        private readonly int _passwordLength;

        public Password(int passwordLength)
        {
            _passwordLength = passwordLength;

            _random = new Random(); 
        }

        public String GeneratePassword()
        {
            string outputPassword = GetPassword();
            return outputPassword;
        }

        private string GetPassword()
        {
            string password = ""; 
            
            for (int i = 0; i < _passwordLength; i++) 
                password += Symbols[_random.Next(Symbols.Length)];

            return password;
        }
    }
}