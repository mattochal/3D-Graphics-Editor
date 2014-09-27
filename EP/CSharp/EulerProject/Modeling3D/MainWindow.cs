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
    public class CursStatus
    {
        private bool isSelect;
        private bool isRubbler;
        private bool isPencil;
        private bool isDrwRec;

        public void Default()
        {
            isDrwRec = false;
            isPencil = false;
            isRubbler = false; 
            isSelect = false;
        }
        
        public void Select()
        {
            Default();
            isSelect = true;
        }

        public void Rubber()
        {
            Default();
            isRubbler = true;
        }

        public void Pencil()
        {
            Default();
            isPencil = true;
        }

        public void DrwRec()
        {
            Default();
            isSelect = true;
        }
    }

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CursStatus.Default();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsSelect = true;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            IsRubbler = true;
        }
    }
}
