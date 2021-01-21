using System;
using System.Collections.Generic;
using System.Text;

namespace project_shiza
{
    class electrostatika
    {
        public virtual void formula() // Функция, которая будет перезаписываться в других классах, которые в свою очередь отнаследованы от электростатики.
        {}
        public void selectformula(int sformula) // Функция выбора формулы
        {
            switch (sformula)
            {
                case 1:
                    electrostatikaKylon ek = new electrostatikaKylon();
                    ek.formula();
                    break;
            }
        }
    }
}
