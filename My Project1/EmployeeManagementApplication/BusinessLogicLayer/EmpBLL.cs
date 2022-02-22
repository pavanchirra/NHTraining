using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    /// <summary>
    /// Done By; Pavan
    /// </summary>
    public class EmpBLL
    {
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
            var empDetailsAdd = EmpDAL.AddEmployeeDetails(empId, empName, empSalary, empAge);
            return empDetailsAdd;
        }

        public static List<string> SearchEmployeeDetailsById(int empId)
        {
            var empDetailsId = EmpDAL.SearchEmployeeDetailsById(empId);
            return empDetailsId;
        }

        public static List<string> SearchEmployeeDetailsByName(string empName)
        {
            var empDetailsName = EmpDAL.SearchEmployeeDetailsByName(empName);
            return empDetailsName;
        }

        public static string[] DisplayEmployeeDetails()
        {
            var empDetails = EmpDAL.DisplayEmployeeDetails();
            return empDetails;
        }
    }
}
