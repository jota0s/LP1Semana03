﻿using System;

namespace RightSize
{
    public class Program
    {
        private static void Main(string[] args)
        {

            foreach (string s in args)
            
                {
                    if (s.Length < 8)
                    {
                        if (s.Length> 3)
                        {
                            Console.WriteLine(s);
                        }
                    }

                    else 
                    {
                        Console.WriteLine("[EARLY STOP]");
                        break;
                    }

                }

        }
    }
}
