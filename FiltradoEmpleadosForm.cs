using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private SqlConnection _conn;
        private string _ciudad = "";
        private string _nombreEmployee = "";
        private string _apellidosEmployee = "";
        public FiltradoEmpleadosForm(List<Employee> employees, SqlConnection connection)
        {
            InitializeComponent();
            _conn = connection;
            _employees = employees;
            LSTBOXEmployees.Items.AddRange(_employees.ToArray());
        }

        private void COMBOXCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ciudad = COMBOXCiudad.Text;
            SearchEmployee();
        }

        private void TXTBOXNombre_TextChanged(object sender, EventArgs e)
        {
            _nombreEmployee = TXTBOXNombre.Text;
            SearchEmployee();
            
        }

        private void SearchEmployee()
        {
            List<Employee> search = new List<Employee>();
            if(_nombreEmployee != "" && _apellidosEmployee != "" && _ciudad == "")
            {
                string cityQuery = @"SELECT * FROM employees e 
                                        INNER JOIN departments d ON e.departme_id = d.department_id
                                        INNER JOIN locations l ON d.location_id = l.location_id
                                        WHERE l.city = @_city";
                using(SqlCommand citySearchCommand = new SqlCommand(cityQuery, _conn))
                {
                    if (_ciudad != "")
                        citySearchCommand.Parameters.AddWithValue("@_city", _ciudad);

                    SqlDataReader recCity = citySearchCommand.ExecuteReader();
                    while (recCity.Read())
                    {
                        int employeeId;
                        string employeeFirstName;
                        string employeeLastName;
                        string employeeEmail;
                        string employeePhoneNumber;
                        DateTime employeeHireDate;
                        int employeeJobId;
                        decimal employeeSalary;
                        int? employeeManagerId;
                        int? employeeDepartmentId;

                        employeeId = recCity.GetInt32(0);
                        employeeLastName = recCity.GetString(2);
                        employeeEmail = recCity.GetString(3);
                        employeeHireDate = recCity.GetDateTime(5);
                        employeeJobId = recCity.GetInt32(6);
                        employeeSalary = recCity.GetDecimal(7);


                        if (recCity.IsDBNull(1))
                            employeeFirstName = null;
                        else
                            employeeFirstName = recCity.GetString(1);

                        if (recCity.IsDBNull(4))
                            employeePhoneNumber = null;
                        else
                            employeePhoneNumber = recCity.GetString(4);

                        if (recCity.IsDBNull(8))
                            employeeManagerId = null;
                        else
                            employeeManagerId = recCity.GetInt32(8);

                        if (recCity.IsDBNull(9))
                            employeeDepartmentId = null;
                        else
                            employeeDepartmentId = recCity.GetInt32(9);

                        Employee employee = new Employee(employeeId, employeeFirstName, employeeLastName,
                            employeeEmail, employeePhoneNumber, employeeHireDate, employeeJobId,
                            employeeSalary, employeeManagerId, employeeDepartmentId);

                        search.Add(employee);
                    }
                }

                foreach (Employee emp in search)
                {
                    if (!emp.FirstName.StartsWith(_nombreEmployee)
                        && !emp.LastName.StartsWith(_apellidosEmployee))
                    {
                        search.Remove(emp);
                    }
                }
            }
            else
            {
                search.Clear();
                search = _employees;
            }
            LSTBOXEmployees.Items.Clear();
            LSTBOXEmployees.Items.AddRange(search.ToArray());
        }

    }
}
