﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingTextFile
{
    public partial class FrmLab1 : Form
    {
        public static string SetFileName;

        public FrmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmFileName file = new FrmFileName();
            file.ShowDialog();

            string getInput = txtInput.Text;

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(FrmFileName.SetFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);

            }
        }
    }
}
