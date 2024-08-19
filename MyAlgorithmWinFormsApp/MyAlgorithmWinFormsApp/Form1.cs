using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAlgorithmWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Input
            int[] data = { 5, 4, 2, 1, 3 };
            
            //Algorithms
            int[] numbers = MyAlgorithms.MyAlgorithms.SelectionSort(data);

            //Output
            /*
                        foreach (var item in numbers)
                        {
                            Console.WriteLine(item);
                        }
            */
            TextBox textBox = new TextBox();
            textBox.Multiline = true;
            textBox.Dock = DockStyle.Fill;
            this.Controls.Add(textBox);

            if (numbers.Any())
            {
                foreach (var item in numbers)
                {
                    textBox.AppendText(item.ToString() + Environment.NewLine);
                }
            }
            else
            {
                textBox.AppendText("Array is empty");
            }

        }
    }
}
