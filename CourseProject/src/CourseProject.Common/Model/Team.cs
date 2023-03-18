using CourseProject.Common.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Common.Model;

public class Team : BaseEntity<int>, IAuditable
{
    public string Name { get; set; } = default!;
    public List<Employee> Employees { get; set; } = default!;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
