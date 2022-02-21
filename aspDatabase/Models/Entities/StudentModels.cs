using aspDatabase.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspDatabase.Models.Entities
{
    public class StudentModels : Student
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int DeptId { get; set; }
    }
}