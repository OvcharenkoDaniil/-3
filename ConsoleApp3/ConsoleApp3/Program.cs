using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    partial class Bus
    {
        string Surname;
        int Bus_number;
        string Initials;
        public string Route_number;
        string Bus_brand;
        int Year_started_operation;
        int Mileage;
        int current_year = 2020;


        string value = "            ";
        string temp = "Hello World!";
        const string Class = "Const";



        static int Counter = 0;
        public int Size;

        //private Bus()
        //{
        //    Console.WriteLine("This is a private constructor!");
        //}
        public string Temp
        {
            get
            {
                return temp;
            }
            protected set
            {
                temp = value;
            }
        }

        static Bus()
        {
            Console.WriteLine("This is a static constructor");
        }

        


    }
}