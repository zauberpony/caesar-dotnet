﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caesar;

namespace CaesarConsoleRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            var system = CaesarSystem.crack("CKDCSQDLQJEWJGFQIBQIIQDUQJJQJCQJJCKDQIJKGFNAWDRSAQJWSQDUQJJQJCOZZNQJ");
            Console.WriteLine(system.a);
            Console.ReadLine();
        }
    }
}