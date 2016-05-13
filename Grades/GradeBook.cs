﻿using System;
using System.Collections.Generic;


namespace Grades
{
    class GradeBook
    {
        private List<float> grades;

        public GradeBook()
        {
            grades = new List<float>();
        }
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
        }

        

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats= new GradeStatistics();
            
            float sum = 0f;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum/grades.Count;
            return stats;
        }
    }
}