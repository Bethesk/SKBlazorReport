﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKBlazorReport.Shared
{
    public class Employee
    {
        [Key]
        public int EmployeeID{ get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}
