using System;
using HRDept.Data.Impl;
using HRDept.Model.Entity;

namespace HRDept
{
    class Program
    {
        static void Main(string[] args)
        {
            Department dept = new Department();
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
