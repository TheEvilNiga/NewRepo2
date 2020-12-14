using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramHub5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            else if (textBox2.Text == "")

            {
                textBox2.Text = "0";
            }
            else
            {
                double[] args = { Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text) };
                switch (comboBox1.Text)
                {
                    case "+":
                        label2.Text = $"Результат: {args[0] + args[1]}";
                        break;
                    case "-":
                        label2.Text = $"Результат: {args[0] - args[1]}";
                        break;
                    case "*":
                        label2.Text = $"Результат: {args[0] * args[1]}";
                        break;
                    case "%":
                        label2.Text = $"Результат: {args[0] / args[1]}";
                        break;
                    case "^2":
                        label2.Text = $"Результат: {args[0] * args[0]}";
                        break;
                    case "^*":
                        label2.Text = $"Результат: {Math.Pow(args[0], args[1])}";
                        break;
                    case "√":
                        label2.Text = $"Результат: {Math.Sqrt(args[0])}";
                        break;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Розовый":
                    this.BackColor = Color.Pink;
                    break;
                case "Ораньжевый":
                    this.BackColor = Color.Orange;
                    break;
                case "Голубой":
                    this.BackColor = Color.Cyan;
                    break;
                case "Серый":
                    this.BackColor = Color.Gray;
                    break;
                default:
                    this.BackColor = Color.White;
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (comboBox3.Text)
            {
                case "Маленький":
                    label1.Font = new Font("MV Boli", 8, FontStyle.Regular);
                    label2.Font = new Font("MV Boli", 8, FontStyle.Regular);
                    label3.Font = new Font("MV Boli", 8, FontStyle.Regular);
                    label4.Font = new Font("MV Boli", 8, FontStyle.Regular);
                    label5.Font = new Font("MV Boli", 8, FontStyle.Regular);
                    comboBox1.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                    comboBox2.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                    comboBox3.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                    comboBox4.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                    button1.Font = new Font("MV Boli", 8, FontStyle.Regular);
                    button2.Font = new Font("MV Boli", 8, FontStyle.Regular);
                    button3.Font = new Font("MV Boli", 8, FontStyle.Regular);
                    button4.Font = new Font("MV Boli", 8, FontStyle.Regular);
                    break;

                case "Средний":
                    label1.Font = new Font("MV Boli", 12, FontStyle.Regular);
                    label2.Font = new Font("MV Boli", 12, FontStyle.Regular);
                    label3.Font = new Font("MV Boli", 12, FontStyle.Regular);
                    label4.Font = new Font("MV Boli", 12, FontStyle.Regular);
                    label5.Font = new Font("MV Boli", 12, FontStyle.Regular);
                    comboBox1.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
                    comboBox2.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
                    comboBox3.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
                    comboBox4.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);
                    button1.Font = new Font("MV Boli", 12, FontStyle.Regular);
                    button2.Font = new Font("MV Boli", 12, FontStyle.Regular);
                    button3.Font = new Font("MV Boli", 12, FontStyle.Regular);
                    button4.Font = new Font("MV Boli", 12, FontStyle.Regular);
                    break;

                case "Большой":
                    label1.Font = new Font("MV Boli", 20, FontStyle.Regular);
                    label2.Font = new Font("MV Boli", 20, FontStyle.Regular);
                    label3.Font = new Font("MV Boli", 20, FontStyle.Regular);
                    label4.Font = new Font("MV Boli", 20, FontStyle.Regular);
                    label5.Font = new Font("MV Boli", 20, FontStyle.Regular);
                    comboBox1.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);
                    comboBox2.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);
                    comboBox3.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);
                    comboBox4.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);
                    button1.Font = new Font("MV Boli", 20, FontStyle.Regular);
                    button2.Font = new Font("MV Boli", 20, FontStyle.Regular);
                    button3.Font = new Font("MV Boli", 20, FontStyle.Regular);
                    button4.Font = new Font("MV Boli", 20, FontStyle.Regular);
                    break;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (comboBox4.Text)
            {
                case "Розовый":
                    label1.ForeColor = Color.Pink;
                    label2.ForeColor = Color.Pink;
                    label3.ForeColor = Color.Pink;
                    label4.ForeColor = Color.Pink;
                    label5.ForeColor = Color.Pink;
                    comboBox1.ForeColor = Color.Pink;
                    comboBox2.ForeColor = Color.Pink;
                    comboBox3.ForeColor = Color.Pink;
                    comboBox4.ForeColor = Color.Pink;
                    button1.ForeColor = Color.Pink;
                    button2.ForeColor = Color.Pink;
                    button3.ForeColor = Color.Pink;
                    button4.ForeColor = Color.Pink;
                    break;
                case "Ораньжевый":
                    label1.ForeColor = Color.Orange;
                    label2.ForeColor = Color.Orange;
                    label3.ForeColor = Color.Orange;
                    label4.ForeColor = Color.Orange;
                    label5.ForeColor = Color.Orange;
                    comboBox1.ForeColor = Color.Orange;
                    comboBox2.ForeColor = Color.Orange;
                    comboBox3.ForeColor = Color.Orange;
                    comboBox4.ForeColor = Color.Orange;
                    button1.ForeColor = Color.Orange;
                    button2.ForeColor = Color.Orange;
                    button3.ForeColor = Color.Orange;
                    button4.ForeColor = Color.Orange;
                    break;
                case "Голубой":
                    label1.ForeColor = Color.Cyan;
                    label2.ForeColor = Color.Cyan;
                    label3.ForeColor = Color.Cyan;
                    label4.ForeColor = Color.Cyan;
                    label5.ForeColor = Color.Cyan;
                    comboBox1.ForeColor = Color.Cyan;
                    comboBox2.ForeColor = Color.Cyan;
                    comboBox3.ForeColor = Color.Cyan;
                    comboBox4.ForeColor = Color.Cyan;
                    button1.ForeColor = Color.Cyan;
                    button2.ForeColor = Color.Cyan;
                    button3.ForeColor = Color.Cyan;
                    button4.ForeColor = Color.Cyan;
                    break;
                case "Серый":
                    label1.ForeColor = Color.Gray;
                    label2.ForeColor = Color.Gray;
                    label3.ForeColor = Color.Gray;
                    label4.ForeColor = Color.Gray;
                    label5.ForeColor = Color.Gray;
                    comboBox1.ForeColor = Color.Gray;
                    comboBox2.ForeColor = Color.Gray;
                    comboBox3.ForeColor = Color.Gray;
                    comboBox4.ForeColor = Color.Gray;
                    button1.ForeColor = Color.Gray;
                    button2.ForeColor = Color.Gray;
                    button3.ForeColor = Color.Gray;
                    button4.ForeColor = Color.Gray;
                    break;
                default:
                    label1.ForeColor = Color.White;
                    label2.ForeColor = Color.White;
                    label3.ForeColor = Color.White;
                    label4.ForeColor = Color.White;
                    label5.ForeColor = Color.White;
                    comboBox1.ForeColor = Color.White;
                    comboBox2.ForeColor = Color.White;
                    comboBox3.ForeColor = Color.White;
                    comboBox4.ForeColor = Color.White;
                    button1.ForeColor = Color.White;
                    button2.ForeColor = Color.White;
                    button3.ForeColor = Color.White;
                    button4.ForeColor = Color.White;
                    break;
            }
        }
       
    }
}
