﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tyuiu.MorozAD.Sprint7.ProjectV6
{
    public partial class FormPatient : Form
    {
        public FormPatient()
        {
            InitializeComponent();
        }

        private void buttonOpen_MAD_Click(object sender, EventArgs e)
        {
            dataGridViewPat_MAD.DataSource = LoadCSV(textBoxPat_MAD.Text);
        }
        private void buttonLoad_MAD_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();
            textBoxPat_MAD.Text = dlg.FileName;
        }
        public List<Patient> LoadCSV(string csvFile) 
        {
            var q = from l in File.ReadAllLines(csvFile)
                    let data = l.Split(';')
                    select new Patient
                    {
                        Num = int.Parse(data[0]),
                        Name = data[1],
                        SureName = data[2],
                        LastName = data[3],
                        Birthday = int.Parse(data[4])
                    };
            return q.ToList();
        }

      
    }
    public class Patient
    {
        public int Num { get; set; }

        public string Name { get; set; }

        public string SureName { get; set; }

        public string LastName { get; set; }

        public double Birthday{ get; set; }



    }

}
