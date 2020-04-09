using System;

namespace chore3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] arr = new string[3, 3];
            arr[0, 0] = arr[2, 2] = "main";
            arr[0, 2] = arr[2, 0] = "sub";
            arr[0, 1] = arr[1, 2] = "up";
            arr[1, 0] = arr[2, 1] = "down";
            arr[1, 1] = "center";
            for(int row = 0; row < 3; row++) {
                for (int col = 0; col < 3; col++)
                    Console.Write("|"+arr[row, col]+"| ");
                Console.WriteLine();
                Console.WriteLine("----------------------");
            }

        }
    }
}
