using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspDatabase.Models.Entities
{
    
    public class DepartmentStudentModel : DepartmentModel
    {
        public List <StudentModel> Students { get; set; }
        public DepartmentStudentModel()
        {
            Students = new List<StudentModel>();
        }
    }

    public class StudentModel
    {
    }
}