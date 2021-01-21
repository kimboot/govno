using System;
using System.Collections.Generic;
using System.Text;

namespace project_shiza
{
    class electrostatikaKylon : electrostatika
    {
        public override void formula()
        {
            Console.WriteLine("Выбрана формула Кулона");
            Console.ReadKey();
        }
    }
}
