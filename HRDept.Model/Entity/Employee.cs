using System;

namespace HRDept.Model.Entity
{
    public class Employee : EntityBase
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Guid Department { get; set; }
        public bool IsFired { get; set; }
    }
}
