using System;
using System.Collections.Generic;
using System.Text;

namespace CAP2025.Day_6
{
    public class Semester
    {
        public int Number;
    }
    public class User
    {
        public string? Name;
    }

    public class Employee : User
    {
        public int EmpID;
        public string? Department;
    }

    public class Student : User
    {
        public int RollNo;
        public int Semester;

        public Student(string nameInput, int RollNoInput)
        {
            RollNo = RollNoInput;
            Name = nameInput;
        }
    }

    public class HOD : Employee
    {
        public HOD(string nameInput, int EmpIDInput, string DepartmentInput)
        {
            Name = nameInput;
            EmpID = EmpIDInput;
            Department = DepartmentInput;
        }

        public void ScheduleExam(Semester semester, Exam exam)
        {
            Console.WriteLine($"Exam for {exam.Subject} in Semester {semester.Number} has been scheduled by HOD {Name}");
        }

        public void AssignExaminer(Examiner examiner, Exam exam)
        {
            Console.WriteLine($"HOD {Name} has assigned Examiner {examiner.Name} for subject {exam.Subject}");
            examiner.ConductExam(exam);
        }
    }

    public class Examiner : Employee
    {
        public Examiner(string nameInput, int EmpIDInput, string DepartmentInput)
        {
            Name = nameInput;
            EmpID = EmpIDInput;
            Department = DepartmentInput;
        }

        public void ConductExam(Exam exam)
        {
            Console.WriteLine($"Exam for {exam.Subject} is being conducted by {Name}");
        }
    }
    public class Exam
    {
        public string? Subject;
        public Semester? semester;
        public Examiner? AssignedExaminer;
    }
    public class ExamScheduleMain
    {
        static void Main(string[] args)
        { 
            HOD hod = new HOD("Dr. Hod", 101, "Computer Science");
            Examiner examiner = new Examiner("abc", 201, "Computer Science");
            Semester semester = new Semester();
            semester.Number = 3;
            Exam exam = new Exam();
            exam.Subject = "Data Structures";
            exam.semester = semester;
            hod.ScheduleExam(semester, exam);
            hod.AssignExaminer(examiner, exam);
        }
    }
}
