using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a, b, c, d,f;
            string t;

            a = textBox1.Text;
            b = textBox2.Text;
            c = textBox3.Text;
            d = textBox4.Text;       
            t = textBox5.Text;

            if (t == "")
            {
                f = "/C ping " + a.ToString() + "." + b.ToString() + "." + c.ToString() + "." + d.ToString() + " -t";
                System.Diagnostics.Process.Start("cmd.exe", f);
            }
            else
            {
                for (int i = Convert.ToInt32(d); i < Convert.ToInt32(t)+1; i++)
                {
                    f = "/C ping " + a.ToString() + "." + b.ToString() + "." + c.ToString() + "." + i.ToString() + " -t";
                    System.Diagnostics.Process.Start("cmd.exe", f);
                }

            }
            
            //MessageBox.Show(f);

            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
