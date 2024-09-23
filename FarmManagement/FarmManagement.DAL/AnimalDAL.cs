namespace FarmManagement.DAL
{
    public class AnimalDAL
    {
        private string connectionString = "Data Source=.;Initial Catalog=FarmManagement;Integrated Security=True";


        public void SaveAnimal(AnimalDTO animal)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Animal (Type, Quantity) VALUES (@Type, @Quantity)", conn);
                cmd.Parameters.AddWithValue("@Type", animal.GetType());
                cmd.Parameters.AddWithValue("@Quantity", animal.GetQuantity());

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