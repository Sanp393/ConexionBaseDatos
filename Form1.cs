using FormsEmployees;
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
    public partial class FormPrincipal : Form
    {
        private SqlConnection connBD;
        private Job jobEmployee;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private List<Employee> employeeList()
        {
            List<Employee> employees = new List<Employee>();

            string stgEmployeesQuery = "SELECT * FROM employees";
            SqlCommand selectEmployeesCommand = new SqlCommand(stgEmployeesQuery, connBD);
            SqlDataReader recEmployees = selectEmployeesCommand.ExecuteReader();

            while (recEmployees.Read())
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

                employeeId = recEmployees.GetInt32(0);
                employeeLastName = recEmployees.GetString(2);
                employeeEmail = recEmployees.GetString(3);
                employeeHireDate = recEmployees.GetDateTime(5);
                employeeJobId = recEmployees.GetInt32(6);
                employeeSalary = recEmployees.GetDecimal(7);


                if (recEmployees.IsDBNull(1))
                    employeeFirstName = null;
                else
                    employeeFirstName = recEmployees.GetString(1);

                if (recEmployees.IsDBNull(4))
                    employeePhoneNumber = null;
                else
                    employeePhoneNumber = recEmployees.GetString(4);

                if (recEmployees.IsDBNull(8))
                    employeeManagerId = null;
                else
                    employeeManagerId = recEmployees.GetInt32(8);

                if (recEmployees.IsDBNull(9))
                    employeeDepartmentId = null;
                else
                    employeeDepartmentId = recEmployees.GetInt32(9);

                Employee employee = new Employee(employeeId, employeeFirstName, employeeLastName, 
                    employeeEmail, employeePhoneNumber, employeeHireDate, employeeJobId,
                    employeeSalary, employeeManagerId, employeeDepartmentId);
            }
            recEmployees.Close();
            return employees;
        }
        private List<Job> jobList()
        {
            List<Job> jobs = new List<Job>();

            string stgJobsQuery = "SELECT * FROM JOBS";
            SqlCommand selectJobsCommand = new SqlCommand(stgJobsQuery, connBD);
            SqlDataReader recJobs = selectJobsCommand.ExecuteReader();

            while (recJobs.Read())
            {
                int jobId = recJobs.GetInt32(0);
                string jobTitle = recJobs.GetString(1);
                decimal? jobMinSalary;
                decimal? jobMaxSalary;

                if (recJobs.IsDBNull(2))
                    jobMinSalary = null;
                else
                    jobMinSalary = recJobs.GetDecimal(2);

                if(recJobs.IsDBNull(3))
                    jobMaxSalary = null;
                else
                    jobMaxSalary = recJobs.GetDecimal(3);

                Job job = new Job(jobId, jobTitle, jobMinSalary, jobMaxSalary);

                jobs.Add(job);
            }
            recJobs.Close();
            return jobs;
        }

        private void BUTConexionBD_Click(object sender, EventArgs e)
        {
            try
            {
                connBD = new SqlConnection(
                @"Data source =79.143.90.12,54321;
                Initial Catalog =GuillermoEmployees;
                Persist Security Info =true;
                User ID =sa;
                Password =123456789");

                connBD.Open();
                LSTBOXJobs.Items.AddRange(jobList().ToArray());
                MessageBox.Show("Se ha encontrado el servidor!!!");
            }
            catch(SqlException ex)
            {
                LABMessage.Text = ex.Message;
                MessageBox.Show("No se ha podido conectar al servidor...");
            }
        }

        private void BUTCloseConnectionBD_Click(object sender, EventArgs e)
        {
            try
            {
                connBD.Close();
                LSTBOXJobs.Items.Clear();
                MessageBox.Show("Se ha desconectado del servidor!!!");
            }
            catch(SqlException ex)
            {
                LABMessage.Text = ex.Message;
                MessageBox.Show("No se ha podido desconectar del servidor...");
            }
        }

        private void BUTChangeJob_Click(object sender, EventArgs e)
        {
            try
            {
                FormCrearJob FCJ = new FormCrearJob();
                FCJ.ShowDialog();
                if (FCJ.DialogResult == DialogResult.OK)
                    jobEmployee = FCJ.nuevoJob;
                    
                InsertJob();
                LSTBOXJobs.Items.AddRange(jobList().ToArray());
                MessageBox.Show("Los datos se han guardado en la base de datos");
            }
            catch(SqlException ex)
            {
                LABMessage.Text = ex.Message;
                MessageBox.Show("No se ha podido cambiar el index: Job");
            }
        }

        private void InsertJob()
        {
            SqlParameter jobTitle = new SqlParameter("@jobEmployeeTitle", SqlDbType.VarChar, 35);
            SqlParameter minSalary = new SqlParameter("@jobEmployeeMinSalary", SqlDbType.Decimal);
            SqlParameter maxSalary = new SqlParameter("@jobEmployeeMaxSalary", SqlDbType.Decimal);

            string queryChangeJob = $@"INSERT INTO JOBS (job_title, min_salary, max_salary) 
            VALUES(@jobEmployeeTitle, @jobEmployeeMinSalary, @jobEmployeeMaxSalary);
            SELECT CAST(SCOPE_IDENTITY() AS INT);";
            using (SqlCommand insertJobCommand = new SqlCommand(queryChangeJob, connBD))
            {
                jobTitle.Value = jobEmployee.Title;

                if (jobEmployee.MinSalary != null)
                    minSalary.Value = jobEmployee.MinSalary;
                else
                    minSalary.Value = DBNull.Value;

                if (jobEmployee.MaxSalary != null)
                    maxSalary.Value = jobEmployee.MaxSalary;
                else
                    maxSalary.Value = DBNull.Value;

                insertJobCommand.Parameters.Add(jobTitle);
                insertJobCommand.Parameters.Add(minSalary);
                insertJobCommand.Parameters.Add(maxSalary);
                object id = insertJobCommand.ExecuteScalar();
                jobEmployee.Id = (int)id;
            }
        }
    }
}
