using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalVarDeclaration();
            DefaultDeclarations();
            NewingDataTypes();
        }

        static void LocalVarDeclaration()
        {
            Console.WriteLine("=> Data Declarations:");
            //Local variables are delcared as so:
            //dataType varName = initialValue;
            int myInt = 0;

            //You can also declare and assign on two lines.
            string myString;
            myString = "This is my character data";

            //Declare 3 bools on a single line.
            bool b1 = true, b2 = false, b3 = b1;

            //Use System.Boolean data type to declare a bool.
            System.Boolean b4 = false;

            Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);

            Console.WriteLine();
        }

        static void DefaultDeclarations()
        {
            Console.WriteLine("=> Default Declarations:");
            int myInt = default;
            Console.WriteLine(myInt);
        }

        static void NewingDataTypes()
        {
            Console.WriteLine("=> Using new to create variables");
            bool b = new bool();            //set to false;
            int i = new int();              //set to 0;
            double d = new double();        //set to 0;
            DateTime dt = new DateTime();   //set to 1/1/0001 12:00:00AM
            Console.WriteLine("{0},{1},{2},{3}", b, i, d, dt);
            Console.WriteLine();
        }
    }
}
