using HRDept.Model.Domain;

namespace HRDept.Model.UseCaseInterfaces
{
    public interface IUseCase
    {
        void CreateDepartment(Department parent);

        void CreateVacancy(Department department, Vacancy vacancy);

        void Recruit(Vacancy vacancy);

        void Transfer(Employee employee, Department department);

        void Fire(Employee employee);
    }
}