using System;

namespace CoreConsole
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("\n\n************** WELCOME TO WISDOM BOOK SHOP *******************\n (This Application Lets you to Display & Search \nAny Details You want about Books Available in Wisdom BookShop) \n\n********************Please login to Access********************");
            Console.WriteLine("\n\n\tPlease Choose from the Following Login Options\n\n");
            Console.WriteLine("\t1. Admin Login  \n\t2. Staff Login  \n\t3. Guest Login  \n\t4. Change Font Size \n\t5. Change Theme \n\t0. Exit \n");
            Console.ReadLine();
        }
    }
}