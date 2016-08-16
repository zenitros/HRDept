using System;
using HRDept.Data.DTO;
using HRDept.Inf.MsSqlImpl;

namespace HRDept
{
    class Program
    {
        static void Main(string[] args)
        {
            DepartmentDTO dept = new DepartmentDTO();
            dept.EntityBaseId = Guid.NewGuid();
            dept.Name = "Head";
            new MsSqlRepo().AddDepartment(dept);


            //Employee newEmpl = new Employee();
            //newEmpl.EntityBaseId = Guid.NewGuid();

            //IRepo repo = new MsSqlRepo();
            //repo.AddEmployee(newEmpl);
        }
    }
}
