using System.Data;
using System.Data.SqlClient;
using FarmManagement_DTO;

namespace FarmManagement_DAL
{
    public class AnimalDAL
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=FarmManagement;Integrated Security=True";


        public int SaveAnimal(AnimalDTO animal)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Animal (Type, Quantity) OUTPUT INSERTED.Id VALUES (@Type, @Quantity)", conn);
                cmd.Parameters.AddWithValue("@Type", animal.GetType());
                cmd.Parameters.AddWithValue("@Quantity", animal.GetQuantity());

                return (int)cmd.ExecuteScalar();
            }
        }

        public void UpdateAnimalQuantity(int animalId, int newQuantity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Animal SET Quantity = @Quantity WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Quantity", newQuantity);
                cmd.Parameters.AddWithValue("@Id", animalId);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllAnimals()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Animal", conn);
                da.Fill(dt);
            }
            return dt;
        }

    }
}