using System;
using System.Collections.Generic;

namespace EmployeesMvc.Models.Entities;

public partial class Company
{
    public int Id { get; set; }

    public string CompanyName { get; set; } = null!;

    public int? EmployeeId { get; set; }
}
