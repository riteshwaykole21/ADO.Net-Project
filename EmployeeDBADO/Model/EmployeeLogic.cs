using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace EmployeeDBADO.Model
{
    public class EmployeeLogic
    {
        private string stringConnectiomn = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
        public List<Employee> getAllEmployees() 
        {
            List<Employee> list = new List<Employee>();
            try 
            {
                SqlConnection conn = new SqlConnection(stringConnectiomn);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * From Employee", conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read()) 
                {
                    Employee emp = new Employee();
                    emp.Id = Convert.ToInt32(rdr.GetValue(0));
                    emp.Name = rdr.GetValue(1).ToString();
                    emp.City = rdr.GetValue(2).ToString();
                    emp.Contact = rdr.GetValue(3).ToString();

                    list.Add(emp);
                }
                
            }
            catch (Exception ex) 
            {

            }
            return list;
        }
    }
}
