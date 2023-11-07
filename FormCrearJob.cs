using FormsEmployees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionBaseDatos
{
    public partial class FormCrearJob : Form
    {
        private string jobTitle;
        private decimal jobMinSalary;
        private decimal jobMaxSalary;
        public Job nuevoJob;
        public FormCrearJob()
        {
            InitializeComponent();
        }

        private void BUTCreateJob_Click(object sender, EventArgs e)
        {
            if(jobTitle != "" && jobMinSalary != 0 && jobMaxSalary != 0)
            {
                nuevoJob = new Job (jobTitle, jobMinSalary, jobMaxSalary);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void TXTBOXTitle_TextChanged(object sender, EventArgs e)
        {
            jobTitle = TXTBOXTitle.Text;
        }

        private void NUMMinSalary_ValueChanged(object sender, EventArgs e)
        {
            jobMinSalary = (decimal)NUMMinSalary.Value;
        }

        private void NUMMaxSalary_ValueChanged(object sender, EventArgs e)
        {
            jobMaxSalary = (decimal)NUMMaxSalary.Value;
        }
    }
}
