//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace aspDatabase.Models.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public Student()
        {
            this.CourseStudents = new HashSet<CourseStudent>();
        }
    
        public int id { get; set; }
        public string Name { get; set; }
        public int DeptId { get; set; }
    
        public virtual ICollection<CourseStudent> CourseStudents { get; set; }
        public virtual Department Department { get; set; }
    }
}
