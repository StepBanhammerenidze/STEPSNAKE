﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STEPSNAKE
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(80, 25);
            Horiaontall_line upLine = new Horiaontall_line(0, 78, 0, '+');
            Horiaontall_line downLine = new Horiaontall_line(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();
            Point p = new Point(4, 5, '*');
            p.Draw();



        }
    }
}       

    
