using System;

namespace Hillel_lesson4_HW
{
    class Programm
    {

        static void Main()
        {




            string password = PasswordGenerator.GeneratePassword(PasswordGenerator.allowedSymbols);

            Console.WriteLine(password);

            Console.ReadKey();

        }
  
        
    }


}