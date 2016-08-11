using System;
using HRDept.Data;
using HRDept.Data.Contracts;
using HRDept.Data.Impl;
using HRDept.Model.Entity;

namespace HRDept
{
    class Program
    {


        static void Main(string[] args)
        {
            TestDB test = new TestDB();


            Employee newEmpl=new Employee();
            newEmpl.EntityBaseId = Guid.NewGuid();

            
            IRepo repo=new MsSqlRepo();
            repo.AddEmployee(newEmpl);
        }
    }
}
