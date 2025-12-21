using System;
public class Student
{
    public string Name;
    public int StudentId;
    public string Course;
    public int Marks;
    
    public void DisplayDetails()
    {
        Console.WriteLine("StudentID: "+StudentId);
        Console.WriteLine("Name: "+Name);
        Console.WriteLine("Course: "+Course);
        Console.WriteLine("Total Marks: "+Marks);
    }
    public void IsPassed()
    {
        if(Marks>=150)
        {
            Console.WriteLine("Student Passed.");
        }
        else
        {
            Console.WriteLine("Student Failed");
        }    
    }

}
public class Program
{
    public static void Main()
    {
        Student student =new Student();
        student.StudentId=12204083;
        student.Name="Bejjipuram Indra Kumar";
        student.Course="CSE";
        student.Marks=200;
        student.DisplayDetails();
        // student.IsPassed();

    }
}


