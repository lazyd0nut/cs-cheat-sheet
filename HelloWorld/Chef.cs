using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IndieHorror
{
    class Chef
    {
        public void MakeDish()
        {
           Console.WriteLine("Chef makes dish."); 
        }
        public void MakeSalad()
        {
            Console.WriteLine("Chef makes salad.");
        }
        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("Chef makes bbq dish.");
        }
    }
}