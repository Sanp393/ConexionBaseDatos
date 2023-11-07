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
    public partial class FiltradoEmpleadosForm : Form
    {
        private List <Employee> _employees;
        private string _ciudad;
        private string _nombreEmployee;
        private string _apellidosEmployee;
        public FiltradoEmpleadosForm(List<Employee> employees)
        {
            InitializeComponent();
            _employees = employees;
            LSTBOXEmployees.Items.AddRange(_employees.ToArray());
        }

        private void TXTBOXCiudad_TextChanged(object sender, EventArgs e)
        {
            _ciudad = TXTBOXCiudad.Text;
        }

        private void TXTBOXNombre_TextChanged(object sender, EventArgs e)
        {
            _nombreEmployee = TXTBOXNombre.Text;
        }
    }
}
