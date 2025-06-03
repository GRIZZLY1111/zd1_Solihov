using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd1_Solihov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void второеЗаданиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zad2 zad2 = new Zad2();
            zad2.ShowDialog();
        }
    }
}
