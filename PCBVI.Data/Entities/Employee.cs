﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBVI.Data
{
    public partial class Employee
    {
        public Employee(string name)
        {
            this.Name = name;
        }
        public string DepartmentName { get; set; }  
    }
}
