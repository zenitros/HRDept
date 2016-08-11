using HRDept.Model.Entity;

namespace HRDept.Data.Contracts
{
    public interface IRepo
    {
        void AddEmployee(Employee data);

        void AddDepartment(Department data);

        void AddVacancy(Vacancy data);

        void UpdateEmployee(Employee data);

        Employee GetEmployee(string name);

        Vacancy GetVacancy();
    }
}
