﻿using System;

namespace IOC
{
    class Program
    {
        static void Main(string[] args)
        {
            BL bl = new BL(new OracleDAL());
            bl.GetProducts().ForEach(x =>
            {
                Console.WriteLine($"{x.Id}-{x.Name}-{x.Price}-{x.Stock}");
            });
            Console.WriteLine("Hello World!");
        }
    }
}
