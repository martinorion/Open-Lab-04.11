using System;
using System.Globalization;

namespace Open_Lab_04._11
{
    public class StringTools
    {
        public string AlphabetSoup(string str)
        {
            char[] characters = str.ToCharArray();
            Array.Sort(characters);
            return new string(characters);
        }
    }
}
