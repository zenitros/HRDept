using System;

namespace HRDept.Model.Domain
{
    public class Employee : Entity
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Guid Department { get; set; }
        public bool IsFired { get; set; }
    }
}
