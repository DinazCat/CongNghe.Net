using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManagement.DTO
{
    internal class GoatDTO : AnimalDTO
    {
        public GoatDTO(int id, int qty) : base(id, qty)
        {
            type = "Goat";
        }

        public override string MakeSound()
        {
            return "Maa Maa";
        }

        public override int ProduceMilk()
        {
            Random rand = new Random();
            return rand.Next(0, 11); // Sữa từ 0 đến 10 lít
        }

        public override float Reproduce()
        {
            Random rand = new Random();
            return rand.Next(1, 4); // Sinh từ 1 đến 3 con
        }
    }
}
