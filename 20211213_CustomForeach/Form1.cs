using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20211213_CustomForeach
{
    public partial class Form1 : Form
    {
        List<string> cities = new List<string>();
        int[] numbers = { 1, 2, 3 };
        public Form1()
        {
            InitializeComponent();
            CreateList();
        }
        void CreateList()
        {
            cities.Add("Çankırı");
            cities.Add("Burdur");
            cities.Add("Of");
        }

        private void run_button_Click(object sender, EventArgs e)
        {
            CustomForeachMethod(cities);
        }

        void CustomForeachMethod(List<string> data)
        {
            List<string> copied_data = data.ToList();

            while (copied_data.Count != 0)
            {
                MessageBox.Show(copied_data[0]);
                copied_data.RemoveAt(0);
            }
        }
    }
}
