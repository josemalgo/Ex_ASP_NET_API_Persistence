﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Domain.Models
{
    public class Employee : Entity
    {

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Position { get; set; }

        public decimal Salary { get; set; }
    }
}
