using System;
using System.Collections.Generic;

namespace HRDept.Model.Entity
{
    public class Department : EntityBase
    {
        public string Name { get; set; }

        public Guid? ParentId { get; set; }
    }
}
