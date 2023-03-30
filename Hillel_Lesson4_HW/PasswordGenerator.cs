using System.Text;

namespace Hillel_lesson4_HW;

public static class PasswordGenerator
{
    public static char[] allowedSymbols = new char[8] { 'f', 'g', 'q', 'B', '7', '!', '%', 'c' };

    public static string GeneratePassword(char[] allowedSymbols)
    {
        Random rnd = new Random();
        StringBuilder prePassword = new StringBuilder(10);

        for (int i = 0; i < prePassword.Capacity; i++)
        {
            int charPosition = rnd.Next(0, 7);
            
            prePassword.Append(allowedSymbols[charPosition]);
        }

        return prePassword.ToString();
    }
}