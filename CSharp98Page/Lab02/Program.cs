﻿using System;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] twoDim = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write(twoDim[i, j]);
                }
            }
            Console.WriteLine();
            foreach(int k in twoDim)
            {
                Console.Write(k);
            }
        }
    }
}