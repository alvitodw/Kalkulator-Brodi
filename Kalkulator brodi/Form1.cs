using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_brodi
{
    public partial class History : Form
    {
        public string operationIs { get; set; } = "";

        public History()
        {
            InitializeComponent();
        }

        public float number1 { get; set; } = 0;
        public float number2 { get; set; } = 0;
        public float result { get; set; } = 0;
        private bool sudahdihitung;
        private bool bukancombobox;
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (sudahdihitung)
            {
                textBox1.Clear();
                sudahdihitung = false;
            }
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sudahdihitung)
            {
                textBox1.Clear();
                sudahdihitung = false;
            }
            textBox1.Text +="2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sudahdihitung)
            {
                textBox1.Clear();
                sudahdihitung = false;
            }
            textBox1.Text +="3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sudahdihitung)
            {
                textBox1.Clear();
                sudahdihitung = false;
            }
            textBox1.Text +="4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sudahdihitung)
            {
                textBox1.Clear();
                sudahdihitung = false;
            }
            textBox1.Text +="5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sudahdihitung)
            {
                textBox1.Clear();
                sudahdihitung = false;
            }
            textBox1.Text +="6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sudahdihitung)
            {
                textBox1.Clear();
                sudahdihitung = false;
            }
            textBox1.Text +="7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (sudahdihitung)
            {
                textBox1.Clear();
                sudahdihitung = false;
            }
            textBox1.Text +="8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (sudahdihitung)
            {
                textBox1.Clear();
                sudahdihitung = false;
            }
            textBox1.Text +="9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (sudahdihitung)
            {
                textBox1.Clear();
                sudahdihitung = false;
            }
            textBox1.Text +="0";
        }

        private void plus_Click(object sender, EventArgs e)
        {
                operationIs += "+";
            bukancombobox = true;
                number1 = float.Parse(textBox1.Text);
                textBox1.Clear();

        }

        private void minus_Click(object sender, EventArgs e)
        {
                operationIs += "-";
            bukancombobox = true;
            number1 = float.Parse(textBox1.Text);
                textBox1.Clear();
        }

        private void multiply_Click(object sender, EventArgs e)
        {
                operationIs += "*";
            bukancombobox = true;
            number1 = float.Parse(textBox1.Text);
                textBox1.Clear();
        }

        private void divide_Click(object sender, EventArgs e)
        {
                operationIs += "/";
            bukancombobox = true;
            number1 = float.Parse(textBox1.Text);
                textBox1.Clear();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            number2 = float.Parse(textBox1.Text);

            if (operationIs.Equals("+"))
                result = number1 + number2;

            if (operationIs.Equals("-"))
                result = number1 - number2;

            if (operationIs.Equals("*"))
                result = number1 * number2;

            if (operationIs.Equals("/"))
                result = number1 / number2;

            textBox1.Text = $"{result}";
            dataGridView1.Rows.Add($"{number1} {operationIs} {number2}", result);
            sudahdihitung = true;
            if (bukancombobox)
            {
                operationIs = "";
            }
            
        }

        private void reset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            dataGridView1.Rows.Clear();
            result = (0);
            number1 = (0);
            number2 = (0);
            operationIs = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex > 0) ;
            string gettext = comboBox1.SelectedItem.ToString();
            
            if (gettext==("Plus +"))
                {
                operationIs = "+";
                }   

            if (gettext==("Minus -")) 
                {
                operationIs = "-";
                }

            if (gettext ==("Multiply *")) 
                {
                operationIs = "*";
                }

            if (gettext ==("Divide /")) 
                {
                operationIs = "/";
                }
            bukancombobox = false;
        }

        private void Operate_Click(object sender, EventArgs e)
        {
                number1 = float.Parse(textBox1.Text);
                textBox1.Clear();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
