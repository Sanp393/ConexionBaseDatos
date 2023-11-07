using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBaseDatos
{
    public class Employee
    {
        private int id;
        private string first_name;
        private string last_name;
        private string email;
        private string phoneNum;
        private DateTime hire_date;
        private int job_id;
        private decimal salary;
        private int? manager_id;
        private int? department_id;

        public int Id { get { return id; } set {  id = value; } }
        public string FirstName { get { return first_name; } set { first_name = value; } }
        public string LastName { get { return last_name;} set { last_name = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string PhoneNum { get {  return phoneNum; } set {  phoneNum = value; } }
        public DateTime Hire_date { get {  return hire_date; } set {  hire_date = value; } }
        public int Job_id { get {return job_id;} set { job_id = value; } }
        public decimal Salary { get {  return salary; } set {  salary = value; } }
        public int? Manager_id { get { return manager_id; } set { manager_id = value; } }
        public int? Department_id { get { return  department_id; } set {  department_id = value; } }

        public Employee(int _id, string _firstname, string _lastname, string _email, string _phonenumber,
                DateTime _hiredate, int _jobid, decimal _salary, int? _managerid, int? _departmentid)
        {
            Id = _id;
            FirstName = _firstname;
            LastName = _lastname;
            Email = _email;
            PhoneNum = _phonenumber;
            Hire_date = _hiredate;
            Job_id = _jobid;
            Salary = _salary;
            Manager_id = _managerid;
            Department_id = _departmentid;
        }

        public override string ToString()
        {
            return Id + " Name: " +  FirstName + " " +  LastName + ".";
        }
    }
}
