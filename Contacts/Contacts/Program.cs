using System;
using System.Collections.Generic;
using System.Globalization;
using Contacts.Services;

namespace Contacts
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // CultureInfo cultureInfo = new CultureInfo("en-US");
            CultureInfo cultureInfo = new CultureInfo("ru-Ru");
            IStarter starter;
            if (cultureInfo.EnglishName == "English (United States)")
            {
                starter = new StarterEnUs(cultureInfo);
            }
            else
            {
                starter = new StarterRu(cultureInfo);
            }

            starter.Start();

            Console.ReadLine();
        }
    }
}
