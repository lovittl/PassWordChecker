﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {

            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
            Console.WriteLine();
            
            /*
            bool pWgood = true;
            CheckPassword.run();
            while (pWgood)
            {
                pWgood = CheckPassword();
            }
            */
        }

        private static bool displayMenu()
        {
            Console.Clear();
            Console.WriteLine("Enter a password:");
            Console.ReadLine();
            string pW = Console.ReadLine();
            
        }

        public static bool CheckPassword(string pW)
        {
            //min 6 chars, max 12 chars
            if (pW.Length < 6 || pW.Length > 12)
            {
                return false;
            }

            //no white space
            if (pW.Contains(" "))
            {
                return false;
            }

            //At least 1 upper case letter
            if (!pW.Any(char.IsUpper))
            {
                return false;
            }

            //At least 1 lower case letter
            if (!pW.Any(char.IsLower))
            {
                return false;
            }

            //No two similar chars consecutively
            for (int i = 0; i < pW.Length - 1; i++)
            {
                if (pW[i] == pW[i + 1])
                {
                    return false;
                }
            }

            //At least 1 special char
            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            char[] specialCharactersArray = specialCharacters.ToCharArray();

            foreach (char c in specialCharactersArray)
            {
                if (pW.Contains(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
