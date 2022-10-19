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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            string strFilename = "customers.xml";

            if (File.Exists(strFilename))
                dsCustomers.ReadXml(strFilename);
        }

        private void Customers_FormClosing(object sender, FormClosingEventArgs e)
        {
            dsCustomers.WriteXml("customers.xml");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
