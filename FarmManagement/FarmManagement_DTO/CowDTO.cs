using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManagement_DTO
{
    public class CowDTO : AnimalDTO
    {
        public CowDTO(int id, int qty) : base(id, qty)
        {
            type = "Cow";
        }

        public override string MakeSound()
        {
            return "Moo Moo";
        }

        public override int ProduceMilk(Random random)
        {
            return random.Next(0, 21); // Sữa từ 0 đến 20 lít
        }

        public override float Reproduce(Random random)
        {
            return random.Next(0, 5);
        }
    }
}
