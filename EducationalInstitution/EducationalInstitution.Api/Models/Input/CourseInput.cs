﻿using EducationalInstitution.Api.Enum;
using EducationalInstitution.Api.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Models.Input
{
    public class CourseInput
    {
        public string Title { get; set; }
        public Department Department { get; set; }
        public CheckStatus CheckStatus { get; set; }
        public double Tuition { get; set; }
        public double Score { get; set; }
        public ExamResult ExamResult { get; set; }
        public string ExamEntranceCard { get; set; }
        public string Certificate { get; set; }

        //Relations
        public Prerequisite? Prerequisite { get; set; }
        public int? PrerequisiteId { get; set; }
    }
}