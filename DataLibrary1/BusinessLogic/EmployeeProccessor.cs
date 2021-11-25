using DataLibrary1.DataAccess;
using DataLibrary1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary1.BusinessLogic
{
   public static class EmployeeProccessor
    {
        public static int CreateEmployee(int employeeId, string name)
        {
            EmployeeModel data = new EmployeeModel
            {
                Employeeid = employeeId,
                Name = name
            };
            String sql = @"insert into dbo.Employee1(Employeeid, Name) values(@employeeId, @name);";
            return SqlDataAccess.SaveData(sql, data);

        }
        public static List<EmployeeModel> LoadEmployees()
        {
            string sql = @"Select id, Employeeid, Name from dbo.Employee1;";
            return SqlDataAccess.LoadData<EmployeeModel>(sql);
        }
        
    }
}
