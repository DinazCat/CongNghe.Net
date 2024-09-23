using System;

namespace FarmManagement_DTO
{
    public abstract class AnimalDTO
    {
        private int id;
        protected string type;
        private int quantity;

        public AnimalDTO(int id, int qty)
        {
            this.id = id;
            this.quantity = qty;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public void SetQuantity(int value)
        {
            quantity = value;
        }

        public string GetType()
        {
            return type;
        }

        public void SetType(string value)
        {
            type = value;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int value)
        {
            id = value;
        }

        public abstract string MakeSound();
        public abstract int ProduceMilk(Random random);
        public abstract float Reproduce(Random random);
    }
}