using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Gajdsgfua";
        }

        private void changeGroup1(Button btn)
        {
            btn.Text = "aaaa";
        }

        private void changeGroup2(Button btn)
        {
            btn.Text = "bbbb";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Text = "jaki indywidualny text";
            this.changeGroup1(sender as Button);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Text = "jaki inny text";
            this.changeGroup1(sender as Button);
        }
    }
}
