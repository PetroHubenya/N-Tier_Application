﻿using Common;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentBLL
    {
        public DataTable GetStudentBelow5(StudentEntity student)
        {
            StudentDAL studentDAL = new StudentDAL();
            if (ValidateID(student.StudentID))
            {
                return studentDAL.FetchSelectedStudents()/*.Tables[0]*/;
            }
            return null;
        }

        private bool ValidateID(int studentID)
        {
            if (studentID > 5)
            {
                throw new ApplicationException("Id Should be less than 5");
            }
            return true;
        }
    }
}
