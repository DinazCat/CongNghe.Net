using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManagement_DTO
{
    public class GoatDTO : AnimalDTO
    {
        public GoatDTO(int id, int qty) : base(id, qty)
        {
            type = "Goat";
        }

        public override string MakeSound()
        {
            return "Maa Maa";
        }

        public override int ProduceMilk(Random random)
        {
            return random.Next(0, 11); // Sữa từ 0 đến 10 lít
        }

        public override float Reproduce(Random random)
        {
            return random.Next(0, 5); 
        }
    }
}
