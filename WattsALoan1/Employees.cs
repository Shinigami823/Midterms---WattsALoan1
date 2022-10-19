using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WattsALoan1
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            string strFilename = "employees.xml";

            if (File.Exists(strFilename))
                dsEmployees.ReadXml(strFilename);
        }

        private void Employees_FormClosing(object sender, FormClosingEventArgs e)
        {
            dsEmployees.WriteXml("employees.xml");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
