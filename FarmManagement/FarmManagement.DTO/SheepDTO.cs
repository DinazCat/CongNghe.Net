using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManagement.DTO
{
    internal class SheepDTO : AnimalDTO
    {
        public SheepDTO(int id, int qty) : base(id, qty)
        {
            type = "Sheep";
        }

        public override string MakeSound()
        {
            return "Baa Baa";
        }

        public override int ProduceMilk()
        {
            Random rand = new Random();
            return rand.Next(0, 6); // Sữa từ 0 đến 5 lít
        }

        public override float Reproduce()
        {
            Random rand = new Random();
            return rand.Next(1, 4); // Sinh từ 1 đến 3 con
        }
    }
}
