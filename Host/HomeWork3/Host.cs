using System;
namespace HomeWork3
{
    class Host
    {
        public static int Main()
        {               
            if (Lang.Months.NumOfMonth() == 12 || Lang.Months.NumOfMonth() == 1 || Lang.Months.NumOfMonth() == 2)
            {
                Console.WriteLine("Сезон года - Зима");
            }
            else if (Lang.Months.NumOfMonth() == 3 || Lang.Months.NumOfMonth() == 4 || Lang.Months.NumOfMonth() == 5)
            {
                Console.WriteLine("Сезон года - Весна");
            }
            else if (Lang.Months.NumOfMonth() == 6 || Lang.Months.NumOfMonth() == 7 || Lang.Months.NumOfMonth() == 8)
            {
                Console.WriteLine("Сезон года - Лето");
            }
            else if (Lang.Months.NumOfMonth() == 9 || Lang.Months.NumOfMonth() == 10 || Lang.Months.NumOfMonth() == 11)
            {
                Console.WriteLine("Сезон года - Осень");
            }
            return 0;
        }
    }
}