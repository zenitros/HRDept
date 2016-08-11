using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDept.Model.Entity
{
    public class Vacancy : EntityBase
    {
        public Guid DepartmentGuid { get; set; }

        public string Description { get; set; }

        public string Position { get; set; }

    }
}
