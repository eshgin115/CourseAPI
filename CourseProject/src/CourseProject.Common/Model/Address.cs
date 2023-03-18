using CourseProject.Common.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Common.Model;

public class Address : BaseEntity<int>, IAuditable
{
    public string Street { get; set; } = default!;
    public string Zip { get; set; } = default!;
    public string City { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string? Phone { get; set; }
    public List<Employee> Employees { get; set; } = default!;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
