using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCoffeeClub.Model
{
    public class CoffeeModel
    {
        public int No { get; set; }
        public string Coffee { get; set; }
        public int Price { get; set; }

        public void GetInformation()
        {
            Console.Write("Enter id : ");
            No = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter name : ");
            Coffee = Console.ReadLine();

            Console.Write("Enter Price : ");
            Price = Convert.ToInt32(Console.ReadLine());
        }
    }
}
