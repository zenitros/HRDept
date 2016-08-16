using System;

namespace HRDept.Data.DTO
{
    public class EmployeeDTO : EntityBase
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Guid Department { get; set; }
        public bool IsFired { get; set; }
    }
}
