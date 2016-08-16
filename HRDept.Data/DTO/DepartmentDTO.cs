using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRDept.Data.DTO
{
    public class DepartmentDTO : EntityBase
    {
        public string Name { get; set; }

        public Guid? ParentId { get; set; }
    }
}
