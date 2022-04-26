﻿using System;

namespace PasswordGenerator
{
    public class GeneratePasswordClass
    {
        private static readonly string[] Symbols = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "[", "]", ";", "'", ".", "/", "{", "}", ":", "?", "<", ">", "|", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "№", "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m", "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M" };
        public static String GeneratePassword(int length) {
            string pass = "";
            Random rnd = new Random();
            for (int i = 0; i < length; i++) {
                pass += Symbols[rnd.Next(Symbols.Length)];
            }
            return pass;
        }

    }
}