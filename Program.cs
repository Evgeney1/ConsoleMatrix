using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Green;
            string userName = Environment.UserName;
            userName = userName.ToUpper()[0] + userName.ToLower().Substring(1);
            string[] matrix = {"Wake up, " + userName+ "...",
                "The Matrix has you...","Follow the white rabbit.",
                "Knock, knock, " + userName + "."};
            Random matrixRandom = new Random();
            System.Threading.Thread.Sleep(1000);
            foreach (var matrixString in matrix)
            {
                Console.Clear();
                foreach (var matrixChar in matrixString)
                {
                    Console.Write(matrixChar);
                    System.Threading.Thread.Sleep(matrixRandom.Next(100, 600));
                }
                System.Threading.Thread.Sleep(2000);
                Console.Write("\r");
            }
            Console.ReadKey();
        }
    }
}
