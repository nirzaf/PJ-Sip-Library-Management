using System;

namespace CoreConsole
{
    internal class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1303:Do not pass literals as localized parameters", Justification = "<Pending>")]
        private static void Main()
        {
            Console.WriteLine("\n\n************** WELCOME TO WISDOM BOOK SHOP *******************\n (This Application Lets you to Display & Search \nAny Details You want about Books Available in Wisdom BookShop) \n\n********************Please login to Access********************");
            Console.WriteLine("\n\n\tPlease Choose from the Following Login Options\n\n");
            Console.WriteLine("\t1. Admin Login  \n\t2. Staff Login  \n\t3. Guest Login  \n\t4. Change Font Size \n\t5. Change Theme \n\t0. Exit \n");
            Console.WriteLine("Please Enter Your Selection");
            ConsoleKeyInfo key = Console.ReadKey(true);
            string _val = string.Empty;

            if (key.Key != ConsoleKey.Backspace)
            {
                var _x = double.TryParse(key.KeyChar.ToString(), out _);
                if (_x)
                {
                    _val += key.KeyChar;
                    Console.Write(key.KeyChar);
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && _val.Length > 0)
                    {
                        _val = _val.Substring(0, (_val.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }

            if (key.Key == ConsoleKey.Enter)
            {
                if (!string.IsNullOrWhiteSpace(_val))
                {
                    switch (_val)
                    {
                        case "1": Console.WriteLine("You have Selected 1"); break;
                        case "2": Console.WriteLine("You have Selected 2"); break;
                        case "3": Console.WriteLine("You have Selected 3"); break;
                        case "4": Console.WriteLine("You have Selected 4"); break;
                        case "5": Console.WriteLine("You have Selected 5"); break;
                        case "0": Console.WriteLine("You have Selected 0"); break;
                    }
                }
            }
        }
    }
}