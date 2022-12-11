﻿using Memento.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Instance
{
    /// <summary>
    /// Memento
    /// </summary>
    public class AddEmployeeToManagerListMemento
    {
        public int ManagerId { get; private set; }
        public Employee? Employee { get; private set; }
        public AddEmployeeToManagerListMemento(int managerId, Employee? employee)
        {
            ManagerId = managerId;
            Employee = employee;
        }
    }
}
