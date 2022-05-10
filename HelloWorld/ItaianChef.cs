using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IndieHorror
{
    class ItalianChef : Chef //inharitance
    {
        public void MakeIalianFood()
        {
            Console.WriteLine("Chef makes italiadamn food.");
        }
        override public void MakeSpecialDish()
        {
            Console.WriteLine("Chef makes pasta.");
        }
    }
}