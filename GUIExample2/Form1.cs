using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIExample2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foodBindingSource.Add(new Food() { Name = "짜장면", Price = 6000 });
            foodBindingSource.Add(new Food() { Name = "짬뽕", Price = 7000 });
            foodBindingSource.Add(new Food() { Name = "탕수육", Price = 14000 });
            foodBindingSource.Add(new Food() { Name = "군만두", Price = 5500 });
            foodBindingSource.Add(new Food() { Name = "꽃빵", Price = 3500 });
            foodBindingSource.Add(new Food() { Name = "멘보샤", Price = 7900 });
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            String s = cb.SelectedItem as String;
            if(s != null)
            {
                MessageBox.Show(s);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;
            Food food = lb.SelectedItem as Food;
            if (food != null)
            {
                MessageBox.Show(food.Name + " : " + food.Price);
            }
        }
    }
}
