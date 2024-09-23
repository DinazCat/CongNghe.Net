using FarmManagement_BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmManagement_BUS;

namespace FarmManagement
{
    public partial class Form1 : Form
    {
        private FarmBUS farmBUS;
        public Form1()
        {
            InitializeComponent();

            farmBUS = new FarmBUS();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int cowCount = (int)numericUpDown1.Value;
            int sheepCount = (int)numericUpDown2.Value;
            int goatCount = (int)numericUpDown3.Value;

            farmBUS.AddAnimal("Cow", cowCount);
            farmBUS.AddAnimal("Sheep", sheepCount);
            farmBUS.AddAnimal("Goat", goatCount);
        }

        private void buttonShowSounds_Click(object sender, EventArgs e)
        {
            string sounds = farmBUS.GetAnimalSounds();
            richTextBox1.Text = sounds;
        }

        private void buttonShowStatistics_Click(object sender, EventArgs e)
        {
            farmBUS.UpdateQuantityStatistics();
            DataTable statistics = farmBUS.GetQuantityStatistics();
            dataGridView1.DataSource = statistics;
        }

        private void buttonShowTotalMilk_Click(object sender, EventArgs e)
        {
            farmBUS.UpdateMilkProductionStatistics();
            DataTable statistics = farmBUS.GetMilkProductionStatistics();
            dataGridView2.DataSource = statistics;

            float totalMilk = farmBUS.GetTotalMilkProduction();
            labelTotal.Text = "Tổng số lít sữa: " + totalMilk.ToString("0.##");
        }
    }
}
