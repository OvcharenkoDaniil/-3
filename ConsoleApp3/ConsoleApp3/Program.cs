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
            static readonly string readonly_string = "You can only read this string!";
            static Bus()
            {
                Console.WriteLine("This is a static constructor");
            }

            public Bus()
            {
            Surname = "Муругин";
            Bus_number = 1;
            Initials ="В.А.";
            Route_number = "111";
            Bus_brand = "МАЗ";
            Year_started_operation = 2019;
            Mileage= 1000;
            Counter++;
            }

            public Bus(string Sur, int Bus_num, string Init, string Route_num, string Brand, int Year, int Mile)
            {
            Surname = Sur;
            Bus_number = Bus_num;
            Initials = Init;
            Route_number = Route_num;
            Bus_brand = Brand;
            Year_started_operation = Year;
            Mileage = Mile;
            Counter++;
            }

            public Bus(string Sur,int Year, string Init,int Bus_num, int Mile ,string Route_num = "666", string Brand = "Mercedess")
            {
                Surname = Sur;
                Bus_number = Bus_num;
                Initials = Init;
                Route_number = Route_num;
                Bus_brand = Brand;
                Year_started_operation = Year;
                Mileage = Mile;
                Counter++;
            }
        

        public void operating_age(ref Bus tr, out int Operation_time)
            {
                Operation_time = current_year - tr.Year_started_operation;

            }

            static void CounterOutput()
            {
                Console.WriteLine("Количество созданных экземпляров объекта Bus равно {0}", Counter);
            }


        }

      
 }