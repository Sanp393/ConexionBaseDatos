using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsEmployees
{
    public class Job
    {
        private int id;
        private string title;
        private decimal? minSalary;
        private decimal? maxSalary;

        public int Id { get { return id; } set { id = value; } }
        public string Title { get { return title; } set { title = value; } }
        public decimal? MinSalary { get {  return minSalary; } set {  minSalary = value; } }
        public decimal? MaxSalary { get { return maxSalary; } set { maxSalary = value; } }


        public Job(string _title, decimal? _minSalary, decimal? _maxSalary)
        {
            title = _title;
            minSalary = _minSalary;
            maxSalary = _maxSalary;
        }

        public Job(int _id, string _title, decimal? _minSalary, decimal? _maxSalary)
        {
            id = _id;
            title = _title;
            minSalary = _minSalary;
            maxSalary = _maxSalary;
        }

        public override string ToString()
        {
            if(minSalary == null && maxSalary == null)
                return id + title + " MinSalary: Null " + " Max salary: Null";
            if (minSalary == null)
                return id + title + " MinSalary: Null " + " Max salary: " + maxSalary;
            if (maxSalary == null)
                return id + title + " MinSalary: " + minSalary + " Max salary: Null";
            else
                return id + title + " MinSalary: " + minSalary + " Max salary: " + maxSalary;
        }
    }
}
