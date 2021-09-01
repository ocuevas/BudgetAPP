using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetAPP
{
    public partial class Form1 : Form
    {
        private float BudgetAmount;
        private float LeftBudget;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BudgetAmount = float.Parse(textBoxBudget.Text.ToString());
            textBoxBudget.Clear();
            labelBudget.Text = this.BudgetAmount.ToString();
            this.LeftBudget = this.BudgetAmount;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addValueTable(comboBox1.Text, textBoxAmount.Text);
            /*this.BudgetAmount =- float.Parse(textBoxAmount.Text.ToString());*/
            
            //Substract
            this.LeftBudget -=  float.Parse(textBoxAmount.Text.ToString());
            
            textBoxAmount.Clear();
            
            // Check when 25% is left
            if((this.BudgetAmount / 4) > this.LeftBudget)
            {
                panel3.BackColor = Color.FromArgb(217, 143, 149);
                labelLeft.ForeColor = Color.FromArgb(166, 33, 44);
                label4.ForeColor = Color.FromArgb(166, 33, 44);

            }else if((this.BudgetAmount / 2) > this.LeftBudget)
            {
                panel3.BackColor = Color.FromArgb(242, 218, 99);
                labelLeft.ForeColor = Color.FromArgb(242, 185, 15);
                label4.ForeColor = Color.FromArgb(242, 185, 15);

            }
            

            labelLeft.Text = this.LeftBudget.ToString();
        }

        private void addValueTable(string name, string amount)
        {
            try
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridView1);
                newRow.Cells[0].Value = name;
                newRow.Cells[1].Value = amount;
                dataGridView1.Rows.Add(newRow);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Mortgage or rent");
            comboBox1.Items.Add("Electricity");
            comboBox1.Items.Add("Gas");
            comboBox1.Items.Add("Water and sewer");
            comboBox1.Items.Add("Cable");
            comboBox1.Items.Add("Food");
            comboBox1.Items.Add("Phone Number");
            comboBox1.Items.Add("Vehicle payment");
            comboBox1.Items.Add("Fuel");
            comboBox1.Items.Add("Bus/taxi fare");
            comboBox1.Items.Add("Insurance");
        }
    }
}
