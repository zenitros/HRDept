using HRDept.Model.Domain;
using HRDept.Model.UseCaseInterfaces;

namespace HRDept.App
{
    public class Service : IUseCase 
    {
        public void CreateDepartment(Department parent)
        {
            throw new System.NotImplementedException();
        }

        public void CreateVacancy(Department department, Vacancy vacancy)
        {
            throw new System.NotImplementedException();
        }

        public void Recruit(Vacancy vacancy)
        {
            throw new System.NotImplementedException();
        }

        public void Transfer(Employee employee, Department department)
        {
            throw new System.NotImplementedException();
        }

        public void Fire(Employee employee)
        {
            throw new System.NotImplementedException();
        }
    }
}
