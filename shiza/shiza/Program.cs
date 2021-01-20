using System;

namespace project_shiza
{
    class Programm //Основной класс, интерфейс работы будет тут.
    {
        static void Main(string[] args)
        {
            char continu = 'д';
            while (continu == 'д') //Цикл для продолжения работы алгоритма
            {
                int vibor_temi;
                Console.WriteLine("Выберите тему : ");

                vibor_temi = Convert.ToInt32(Console.ReadLine()); //Ввод темы (класса)
                if (Convert.ToBoolean(vibor_temi = 1))
                {
                    Console.WriteLine("Выбран раздел 'Этектростатика'");
                    Console.WriteLine("Выбирите формулу : "); // Здесь надо вставить экземпляр класса электростатики

                }






            }


        }
    }
}
