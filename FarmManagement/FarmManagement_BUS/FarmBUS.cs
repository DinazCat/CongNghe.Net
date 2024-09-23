using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmManagement_DAL;
using FarmManagement_DTO;

namespace FarmManagement_BUS
{
    public class FarmBUS
    {
        private AnimalDAL animalDAL;
        private ProductionDAL productionDAL;

        public List<AnimalDTO> Animals { get; set; }

        public FarmBUS()
        {
            animalDAL = new AnimalDAL();
            productionDAL = new ProductionDAL();
            Animals = new List<AnimalDTO>();
        }

        // Thêm động vật vào nông trại
        public void AddAnimal(string type, int quantity)
        {
            AnimalDTO animal;

            switch (type)
            {
                case "Cow":
                    animal = new CowDTO(0, quantity);
                    break;
                case "Sheep":
                    animal = new SheepDTO(0, quantity);
                    break;
                case "Goat":
                    animal = new GoatDTO(0, quantity);
                    break;
                default:
                    throw new ArgumentException("Invalid animal type");
            }

            int animalId =  animalDAL.SaveAnimal(animal);
            animal.SetId(animalId);
            Animals.Add(animal);
        }


        public string GetAnimalSounds()
        {
            getAllAnimals();

            List<string> sounds = new List<string>();

            foreach (var animal in Animals)
            {
                for (int i = 0; i < animal.GetQuantity(); i++)
                {
                    sounds.Add(animal.MakeSound());
                }
            }

            return string.Join(", ", sounds);
        }

        void getAllAnimals()
        {
            var allAnimals = animalDAL.GetAllAnimals(); // Lấy danh sách tất cả gia súc từ CSDL
            Animals = new List<AnimalDTO>();

            foreach (DataRow row in allAnimals.Rows)
            {
                int id = (int)row["Id"];
                string type = (string)row["Type"];
                int quantity = (int)row["Quantity"];

                AnimalDTO animal;
                switch (type)
                {
                    case "Cow":
                        animal = new CowDTO(id, quantity);
                        break;
                    case "Sheep":
                        animal = new SheepDTO(id, quantity);
                        break;
                    case "Goat":
                        animal = new GoatDTO(id, quantity);
                        break;
                    default:
                        throw new ArgumentException("Invalid animal type");
                }

                Animals.Add(animal);
            }
        }

        public DataTable GetQuantityStatistics()
        {      
            DataTable statistics = animalDAL.GetAllAnimals();

            DataTable filteredStatistics = new DataTable();
            filteredStatistics.Columns.Add("Loại gia súc", typeof(string));
            filteredStatistics.Columns.Add("Số lượng", typeof(int));

            foreach (DataRow row in statistics.Rows)
            {
                DataRow newRow = filteredStatistics.NewRow();
                newRow["Loại gia súc"] = row["Type"];
                newRow["Số lượng"] = row["Quantity"];
                filteredStatistics.Rows.Add(newRow);
            }
            return filteredStatistics;
        }

        public void UpdateQuantityStatistics()
        {
            getAllAnimals();
            Random random = new Random();
            foreach (var animal in Animals)
            {
                // Tính tổng số gia súc sinh ra
                int totalNewBorn = 0;
                for (int i = 0; i < animal.GetQuantity(); i++)
                {
                    float newBorn = animal.Reproduce(random);
                    totalNewBorn += (int)newBorn;
                }

                // Cập nhật số lượng gia súc
                animal.SetQuantity(animal.GetQuantity() + totalNewBorn);
                animalDAL.UpdateAnimalQuantity(animal.GetId(), animal.GetQuantity());
            }
        }

        public DataTable GetMilkProductionStatistics()
        {
            return productionDAL.GetProductionStatistics();
        }

        public void UpdateMilkProductionStatistics()
        {
            getAllAnimals();
            Random random = new Random();
            foreach (var animal in Animals)
            {
                for (int i = 0; i < animal.GetQuantity(); i++)
                {
                    int milkProduced = animal.ProduceMilk(random);

                    // Lưu thông tin sản xuất sữa vào CSDL
                    productionDAL.InsertProduction(animal.GetId(), milkProduced);
                }
            }
        }
        public float GetTotalMilkProduction()
        {
            float totalMilk = 0;
            DataTable dt = GetMilkProductionStatistics();

            foreach (DataRow row in dt.Rows)
            {
                totalMilk += Convert.ToSingle(row["TotalMilk"]);
            }
            return totalMilk;
        }
    }
}
