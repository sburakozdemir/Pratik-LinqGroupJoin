﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik_LinqGroupJoin
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int ClassId { get; set; }

        public Student (int studentID, string studentName, int classId)
        {
            StudentId = studentID;
            StudentName = studentName;
            ClassId = classId;

        }
    }
}
