﻿namespace Exam2901.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeName { get; set; }
        public string Rank { get; set; }

        // Foreign Key
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
