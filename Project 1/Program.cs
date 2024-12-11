using System.Runtime.InteropServices;
using System;
using System.Security.Claims;

namespace Project_1
{
    internal class Program
    {


        static void Main(string[] args)
        {

            #region assiment

           
            #region q1
            /*
            Console.WriteLine("Enter a number: ");

            int Num =Convert.ToInt32( Console.ReadLine ());
            */
            #endregion

            #region q2

            /*
            int x;
            x = 5;
            int y;
            y = 3;

            Console.WriteLine(x);
            Console.WriteLine(y);


            y = x;

            Console.WriteLine(x);
            Console.WriteLine(y);

            //in first run print x=5 and y=3
            //in sec run print x,y = 5
            */
            #endregion

            #region q3

            Point p1;
            p1 = new Point();

            Point p2 = new Point();

            p2 = p1;
            p2.x = 15;


            Console.WriteLine(p1.x);
            Console.WriteLine(p2.x);

            p1.y = 100;
            Console.WriteLine(p2.y);


            //when modifying in p1.y it affect in p2.y and get same value

            #endregion


             #endregion

            #region Demo


            #region Error types

            //Syntax Error  == wrong word 
            //Logical Error == wrong logic 
            //Run Time Error == like /0
            //Warning == not error but warning to posiple wrong
            #endregion


            #region DeclareVariables

            int number;
            number = 1000;
            Console.WriteLine(number);


            #endregion


            #region DataType

            //Struct (Byte -- Short -- int -- Long //Float -- Double -- Decimal -- Char -- Bool -- Datetime)
            //Enum
            //Class (Object -- String -- Array -- Delegate)
            //Interface
            #endregion


            #region Value Types

            int x;
            x = 20;
            int y;
            y = 10;

            Console.WriteLine(x);
            Console.WriteLine(y);


            y = x;
            x++;

            Console.WriteLine(x);
            Console.WriteLine(y);

       
            #endregion



            #endregion
        }
    }
}