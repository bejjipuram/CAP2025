using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CAP2025.Day_15
{
    public class EmployeeRe
    {
        public string Name { get; set; }
        public int EmployeeID { get; set; }
        public int Rank { get; set; }
        public class ExampleWorkOutGeneric
        {
            public static List<EmployeeRe> EmployeeReList = new List<EmployeeRe>();
            public ExampleWorkOutGeneric()
            {

            }
            public static void Main(string[] args)
            {
                var localEmpList = GetData();
                var filterList = from emp in localEmpList select emp;
                foreach(EmployeeRe emp in filterList)
                {
                    emp.Name= emp.Name;
                }
            }
            public List<EmployeeRe> GetData()
            {
                EmployeeReList.Add(new EmployeeRe() { EmployeeID = 1, Name = "A", Rank = 1 });
                EmployeeReList.Add(new EmployeeRe() { EmployeeID = 2, Name = "B", Rank = 2 });
                EmployeeReList.Add(new EmployeeRe() { EmployeeID = 3, Name = "C", Rank = 4 });
                return EmployeeReList;
            }
        }

    }
}
