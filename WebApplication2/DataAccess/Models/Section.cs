﻿namespace WebApplication2.DataAccess.Models
{
    public class SectionModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SectionCourseModel> CourseSection { get; set; }
    }
}
