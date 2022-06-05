using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    /// <summary>
    /// Class of extensions.
    /// </summary>
    internal static class MyExtensions
    {
        /// <summary>
        /// Method gets alphabet and symbols we need to display in contacts list in list of strings according to cultureinfo.
        /// </summary>
        /// <param name="cultureInfo">Cultureinfo.</param>
        /// <returns>List of strings of symbols concats list must have.</returns>
        public static List<string> GetAlphabet(this CultureInfo cultureInfo)
        {
            var alphabet = new List<string>();
            if (cultureInfo.EnglishName == "English (United States)")
            {
                alphabet = new List<string>();
                for (char c = 'A'; c <= 'Z'; ++c)
                {
                    alphabet.Add(c.ToString());
                }
            }
            else
            {
                alphabet = new List<string>();
                for (char c = 'А'; c <= 'Я'; ++c)
                {
                    alphabet.Add(c.ToString());
                }
            }

            alphabet.Add("#");
            alphabet.Add("0-9");
            return alphabet;
        }
    }
}
