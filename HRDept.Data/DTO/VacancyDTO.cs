using System;

namespace HRDept.Data.DTO
{
    public class VacancyDTO : EntityBase
    {
        public Guid DepartmentGuid { get; set; }

        public string Description { get; set; }

        public string Position { get; set; }

    }
}
