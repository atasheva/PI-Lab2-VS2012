using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PI_Lab2_VS2012.ViewModels
{
    public class EmployeeListViewModel
    {
        public List<EmployeeViewModel> Employees { get; set; }
        public string UserName { get; set; }
    }
}