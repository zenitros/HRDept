using System;
using HRDept.Data.DTO;
using HRDept.Model.Domain;

namespace HRDept.Model.RepositoryInterfaces
{
    public interface IRepository
    {
        void AddEmployee(EmployeeDTO data);

        void AddDepartment(DepartmentDTO data);

        void AddVacancy(VacancyDTO data);

        void UpdateEmployee(EmployeeDTO data);

        EmployeeDTO GetEmployee(string name);

        VacancyDTO GetVacancy();
    }
}
