using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EmpDAL
    {
        public static string filePath = "C:\\C#\\Project\\My Project1\\EmployeeData.txt";
        /// <summary>
        /// Add Employee Details
        /// </summary>
        /// <param name="empId"></param>
        /// <param name="empName"></param>
        /// <param name="empSalary"></param>
        /// <param name="empAge"></param>
        /// <returns></returns>
        public static bool AddEmployeeDetails(int empId, string empName, int empSalary, int empAge)
        {
            try
            {
                string empDetails = string.Concat(empId, ",", empName, ",", empSalary, ",", empAge);
                File.AppendAllText(filePath, empDetails + Environment.NewLine);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        /// <summary>
        /// Search Employee Details By Id
        /// </summary>
        /// <param name="empId"></param>
        /// <returns></returns>
        public static List<string> SearchEmployeeDetailsById(int empid)
        {
            var empData = File.ReadAllLines(filePath);
            List<string> found = new List<string>();
            foreach (string emp in empData)
            {
                var empDetails = emp.Split(',');
                if (Convert.ToInt32(empDetails[0]) == empid)
                {
                    found.Add(emp);
                    break;
                }
            }
            return found;
        }
        /// <summary>
        /// Search Employee Details By Name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static List<string> SearchEmployeeDetailsByName(string empName)
        {
            var empData = File.ReadAllLines(filePath);
            List<string> found = new List<string>();
            foreach (string emp in empData)
            {
                var empDetails = emp.Split(',');
                if ((empDetails[1].Contains(empName)))
                {
                    found.Add(emp);

                }
            }
            return found;
        }
        public static string[] DisplayEmployeeDetails()
        {
            var empData = File.ReadAllLines(filePath);
            return empData;
        }
    }
}
