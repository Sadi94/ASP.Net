using aspDatabase.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspDatabase.Models.Entities
{
    public class CourseModel : Cours
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Offeredby { get; set; }
    }
}