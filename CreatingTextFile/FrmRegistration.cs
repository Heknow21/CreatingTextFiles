using System;
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
    public partial class frmRegistration : Form
    {


        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            string[] ListOfProgram = new string[]
            {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information System",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };
            for (int i = 0; i < 6; i++)
            {
                cbProgram.Items.Add(ListOfProgram[i].ToString());
            }
            string[] ListOfGender = new string[]
            {
                "Male",
                "Female"
            };
            for (int j = 0; j < 2; j++)
            {
                cbGender.Items.Add(ListOfGender[j].ToString());
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string getStudentNo = txtStudentNo.Text.ToString();
            string getProgram = cbProgram.Text.ToString();
            string getLastName = txtLastName.Text.ToString();
            string getFirstName = txtFirstName.Text.ToString();
            string getMI = txtMI.Text.ToString();
            string getAge = txtAge.Text.ToString();
            string getGender = cbGender.Text.ToString();
            string getBirthday = dtDatePicker.Text.ToString();
            string getContactNo = txtContactNo.Text.ToString();

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
            {
                outputFile.WriteLine("Student No: " + getStudentNo + ".");
                Console.WriteLine("Student No: " + getStudentNo + ".");

                outputFile.WriteLine("Program: " + getProgram + ".");
                Console.WriteLine("Program: " + getProgram + ".");

                outputFile.WriteLine("Full Name: " + getLastName + ", " + getFirstName + " " + getMI + ".");
                Console.WriteLine("Full Name: " + getLastName + ", " + getFirstName + " " + getMI + ".");

                outputFile.WriteLine("Age: " + getAge + ".");
                Console.WriteLine("Age: " + getAge + ".");

                outputFile.WriteLine("Gender: " + getGender + ".");
                Console.WriteLine("Gender: " + getGender + ".");

                outputFile.WriteLine("Birthday: " + getBirthday + ".");
                Console.WriteLine("Birthday: " + getBirthday + ".");

                outputFile.WriteLine("Contact No.: " + getContactNo + ".");
                Console.WriteLine("Contact No.: " + getContactNo + ".");

            }
        }
    }
}
