﻿using EducationalInstitution.Api.Enum;
using System.ComponentModel.DataAnnotations;

namespace EducationalInstitution.Api.Models.Input
{
    public class CourseInput
    {
        public string Title { get; set; }
        public Department Department { get; set; }
        public CheckStatus CheckStatus { get; set; }
        [Required ]
        public decimal Tuition { get; set; }
        [Range(0, double.MaxValue)]
        public double Score { get; set; }
        public ExamResult ExamResult { get; set; }
        public string? ExamEntranceCard { get; set; }
        public string? Certificate { get; set; }
        public string? Prerequisite { get; set; }
    }
}