﻿using EducationalInstitution.Api.Models.Common;

namespace EducationalInstitution.Api.Models.Entities
{
    public class Class : BaseEntity
    {
        public int Number { get; set; }
        public  byte Capacity { get; set; }


        //Relations
        public Instructor Instructor { get; set; }
        public int InstructorId { get; set; }

        public Course Course { get; set; }
        public int CourseId { get; set; }

        //Collections
        public ICollection<Student> Students { get; set; }
    }
}