using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManagement.DAL
{
    internal class ProductionDAL
    {
        private string connectionString = "Data Source=.;Initial Catalog=FarmManagement;Integrated Security=True";

        // Lưu thông tin sản xuất vào cơ sở dữ liệu
        public void SaveProduction(int animalId, float milkProduction, int reproduction)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Production (AnimalId, MilkProduction, Reproduction) VALUES (@AnimalId, @MilkProduction, @Reproduction)", conn);
                cmd.Parameters.AddWithValue("@AnimalId", animalId);
                cmd.Parameters.AddWithValue("@MilkProduction", milkProduction);
                cmd.Parameters.AddWithValue("@Reproduction", reproduction);

                cmd.ExecuteNonQuery();
            }
        }

        // Lấy thống kê sản xuất theo gia súc
        public DataTable GetProductionStatistics()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT a.Type, SUM(p.MilkProduction) AS TotalMilk, SUM(p.Reproduction) AS TotalReproduction FROM Production p JOIN Animal a ON p.AnimalId = a.Id GROUP BY a.Type", conn);
                da.Fill(dt);
            }
            return dt;
        }
    }
}
