using System.Data.Entity;
using HRDept.Model.Entity;

namespace HRDept.Data
{
    public class TestDB : DropCreateDatabaseIfModelChanges<HRDeptContext>
    {
        protected override void Seed(HRDeptContext context)
        {
            Employee employee = new Employee {Name = "dsfsdf"};
            context.Employees.Add(employee);
            context.SaveChanges(); 

        }
    }
}
