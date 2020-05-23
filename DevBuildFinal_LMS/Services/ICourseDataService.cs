﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevBuildFinal_LMS.Models;

namespace DevBuildFinal_LMS.Services
{
    public interface ICourseDataService
    {
        public IEnumerable<Course> GetCourses();
        public Course GetCourseById(int id);
        public int ChangeEnrollmentStatus(StudentCourse studentCourse);
        public int AddCourse(Course course);
        public int AddTeacherToCourse(Course course);
        public int AddModule(Module module);
        public IEnumerable<Module> ViewModulesById(int id);
    }
}