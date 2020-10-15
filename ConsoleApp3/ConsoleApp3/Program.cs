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

        partial class Bus
        {
            public void Output()
            { 
                Console.WriteLine("{0},{1} является водителем автобуса номер {2}, движущегося по маршруту {3}. Марка автобуса: {4}, год начала эксплуатации: {5}, пробег: {6}", 
                Surname, Initials,Bus_number, Route_number,Bus_brand, Year_started_operation, Mileage);
        
            }

        }
        class Program
        {

            static void Main(string[] args)
            {
                int Operation_time, Size;
            string num;
            
            Console.WriteLine("Введите размер массива классов Bus: ");
                Size = int.Parse(Console.ReadLine());
                Bus[] Buses = new Bus[Size];

            //Простой конструктор (без параметров)
            Buses[0] = new Bus();
            Buses[0].Output();
            Console.WriteLine();

            //Конструктор с параметрами
            Buses[1] = new Bus("Куликов", 3, "Д.Н.", "30", "АААА", 2016, 3000);
            Buses[1].Output();
            Console.WriteLine();
            //Конструктор с параметрами по умолчанию
            Buses[2] = new Bus("Савельев", 2014, "Д.А.",5, 5000);
            Buses[2].Output();
            Buses[2].operating_age(ref Buses[2], out Operation_time);
            Console.WriteLine("Количество лет эксплуатации автобуса: {0}", Operation_time);
            Console.WriteLine();


            Console.WriteLine($"Строка представляющая объект Buses: {Buses[0].ToString()}");

            Console.WriteLine($"Экземпляры Buses[0] и Buses[1] равны: {Buses[0].Equals(Buses[1])}");

            Console.WriteLine($"Хеш-код экземпляра Buses[0]: {Buses[0].GetHashCode()}");

            Console.WriteLine($"Тип экземпляра Buses[0]: {Buses[0].GetType()}");

            
            
            }
        }
    }