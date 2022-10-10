using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static If_Form.Program;



namespace If_Form
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox2.Text = Properties.Settings.Default.outMessage.ToString();
            textBox1.Text = Properties.Settings.Default.x.ToString();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Дано трехзначное число. Не прибегая к использованию строк вывести наибольшую из его цифр\n");
            //Console.WriteLine("Введите трёхзначное число:");

            int x = Convert.ToInt32(textBox1.Text);
            string outMessage = Logic.Compare(x);
            this.textBox2.Text = outMessage;

            Properties.Settings.Default.x = x;
            Properties.Settings.Default.outMessage = outMessage;
            Properties.Settings.Default.Save();


            //Console.WriteLine(outMessage);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void задачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дано трехзначное число. Не прибегая к использованию строк вывести наибольшую из его цифр");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (char)Keys.Enter)
            {
                button1_Click(button1,null);
            }
        }
    }
}
