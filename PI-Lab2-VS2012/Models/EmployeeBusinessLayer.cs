﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PI_Lab2_VS2012.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee emp = new Employee();
            emp.FirstName = "johnson";
            emp.LastName = " fernandes";
            emp.Salary = 14000;
            employees.Add(emp);

            emp = new Employee();
            emp.FirstName = "John";
            emp.LastName = " doe";
            emp.Salary = 16000;
            employees.Add(emp);

            emp = new Employee();
            emp.FirstName = "Marry";
            emp.LastName = " jane";
            emp.Salary = 20000;
            employees.Add(emp);

            return employees;
        }

    }
}