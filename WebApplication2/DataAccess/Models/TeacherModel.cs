﻿namespace WebApplication2.DataAccess.Models
{
    public class TeacherModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<SectionCorseModel> Courses { get; set; }
    }
}
