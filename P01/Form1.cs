using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static private void Vypis(int [] pole, ListBox lb)
        {

            foreach( int i in pole)
            {
                lb.Items.Add(i.ToString());
            }
        }

        static private bool JeDokonale(int cislo, out int max, out int min)
        {
            max = 0;
            min = 0;
            int i = 0;
            int soucetdel = 0;
            while (i < cislo)
            {
                i++;
                if (cislo % i == 0)
                {
                    soucetdel += i;

                    if (i > 1 && i > max) max = i;
                    if (i > 1 && i < min) min = i;


                }
            }
            if (soucetdel == cislo)
            {
                return true;
            }
            else return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int max = 0;
            int min = 0;
            bool Jedokonale;
            int[] pole = new int[n];
            Random rnd = new Random();

            for(int i = 0; i < n; i++)
            {
                pole[i] = rnd.Next(-5, 25);
            }

            Vypis(pole, listBox1);

            
            for ( int k = 0; k < n; k++)
            {
                Jedokonale = JeDokonale(pole[k], out max, out min);

                if(Jedokonale == true)
                {
                    MessageBox.Show("cislo" + pole[k] + " je dokonale");
                }

            }
        }
    }
}
