using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FarmManagement_DAL
{
    public class ProductionDAL
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=FarmManagement;Integrated Security=True";
        // Lưu thông tin sản xuất vào cơ sở dữ liệu
        public void InsertProduction(int animalId, float milkProduction)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO MilkProduction (AnimalId, MilkProduction) VALUES (@AnimalId, @MilkProduction)", conn);
                cmd.Parameters.AddWithValue("@AnimalId", animalId);
                cmd.Parameters.AddWithValue("@MilkProduction", milkProduction);
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
                SqlDataAdapter da = new SqlDataAdapter("SELECT a.Type, SUM(p.MilkProduction) AS TotalMilk FROM MilkProduction p JOIN Animal a ON p.AnimalId = a.Id GROUP BY a.Type", conn);
                da.Fill(dt);
            }
            return dt;
        }
    }
}