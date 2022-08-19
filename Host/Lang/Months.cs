using System;

namespace Lang 
{
    public class Months
    {
        public static int NumOfMonth()
        {
            Console.WriteLine("Выберите номер месяца от 1 до 12");
            int selection = Convert.ToInt16(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    Console.WriteLine("Вы выбрали 1ый месяц - Январь, в нём 31 дней");
                    break;
                case 2:
                    Console.WriteLine("Вы выбрали 2ой месяц - Февраль, в нём 28 дней");
                    break;
                case 3:
                    Console.WriteLine("Вы выбрали 3ий месяц - Март, в нём 31 дней");
                    break;
                case 4:
                    Console.WriteLine("Вы выбрали 4ый месяц - Апрель, в нём 30 дней");
                    break;
                case 5:
                    Console.WriteLine("Вы выбрали 5ый месяц - Май, в нем 31 дней");
                    break;
                case 6:
                    Console.WriteLine("Вы выбрали 6ой месяц - Июнь, в нем 30 дней");
                    break;
                case 7:
                    Console.WriteLine("Вы выбрали 7ой месяц - Июль, в нем 31 дней");
                    break;
                case 8:
                    Console.WriteLine("Вы выбрали 8ой месяц - Август,в нем 31 дней ");
                    break;
                case 9:
                    Console.WriteLine("Вы выбрали 9ый месяц - Сентябрь, в нем 30 дней");
                    break;
                case 10:
                    Console.WriteLine("Вы выбрали 10ый месяц - Октябрь, в нем 31 дней ");
                    break;
                case 11:
                    Console.WriteLine("Вы выбрали 11ый месяц - Ноябрь, в нем 30 дней");
                    break;
                case 12:
                    Console.WriteLine("Вы выбрали 12ый месяц - Декабрь, в нем 31 дней ");
                    break;
                default:
                    Console.WriteLine("Вы выбрали несуществующий месяц");
                    break;
            }
            return selection;
        }
    }
}
