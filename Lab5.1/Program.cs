﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab5._1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.InputEncoding = Encoding.GetEncoding(1251);
            Manager manager = new Manager();
            manager.setComands();
            Console.ReadKey();
        }

    }
}
