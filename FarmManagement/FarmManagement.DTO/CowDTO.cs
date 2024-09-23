using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManagement.DTO
{
    internal class CowDTO : AnimalDTO
    {
        public CowDTO(int id, int qty) : base(id, qty)
        {
            type = "Cow";
        }

        public override string MakeSound()
        {
            return "Moo Moo";
        }

        public override int ProduceMilk()
        {
            Random rand = new Random();
            return rand.Next(0, 21); // Sữa từ 0 đến 20 lít
        }

        public override float Reproduce()
        {
            Random rand = new Random();
            return rand.Next(1, 4); // Sinh từ 1 đến 3 con
        }
    }
}
