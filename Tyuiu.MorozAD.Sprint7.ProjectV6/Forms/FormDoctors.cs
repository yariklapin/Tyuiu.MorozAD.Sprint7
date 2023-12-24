using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.MorozAD.Sprint7.ProjectV6
{
    public partial class FormDoctor : Form
    {
        public FormDoctor()
        {
            InitializeComponent();
        }

        private void labelDoctor3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttondoctor1_Click(object sender, EventArgs e)
        {
            FormDoctor1 formd1 = new FormDoctor1();
            formd1.ShowDialog();
        }

        private void buttonDoctor2_Click(object sender, EventArgs e)
        {
            FormDoctor2 formd2 = new FormDoctor2();
            formd2.ShowDialog();
        }

        private void buttonDoctor3_Click(object sender, EventArgs e)
        {
            FormDoctor3 formd3 = new FormDoctor3();
            formd3.ShowDialog();
        }

        private void buttonDoctor4_Click(object sender, EventArgs e)
        {
            FormDoctor4 formd4 = new FormDoctor4();
            formd4.ShowDialog();
        }
    }
}
