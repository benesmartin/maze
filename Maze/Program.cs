using System;

namespace Maze
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = 11;
            var znakI = "#";
            var znakJ = "-";
            var pole = new string[size, size];
            for (int i = 0; i < pole.GetLength(0); i++)
            {
                for (int j = 0; j < pole.GetLength(1); j++)
                {
                    if(j == 0 || j == size - 1 || i == 0 || i == size - 1) 
                    {
                        pole[i, j] = znakI;
                    }
                    else
                    {
                        pole[i, j] = znakJ;
                    }  
                    Console.Write("{0} ", pole[i, j]);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
