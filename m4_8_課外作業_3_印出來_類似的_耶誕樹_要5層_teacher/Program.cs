﻿using System;
class P
{
    static void Main()
    {
        Console.WriteLine("");
        Console.WriteLine("開始");

        int num_levels = 5;
        // fix #1
        int num_blank;
        int num_star;
        int num_new_line = 1;

        num_blank = num_levels - 1;
        num_star = 1;

        int t = 1;
        while (t <= num_levels)
        {
            {
                int i = 1;
                while (i <= num_blank)
                {
                    Console.Write(" ");
                    i += 1;
                }
            }
            {
                int i = 1;
                while (i <= num_star)
                {
                    Console.Write("*");
                    i += 1;
                }
            }
            {
                int i = 1;
                while (i <= num_new_line)
                {
                    Console.Write("\n");
                    i += 1;
                }
            }


            num_blank -= 1;
            num_star += 2;
            t += 1;
        }




        Console.WriteLine("結束");
        Console.WriteLine("");
    }
}