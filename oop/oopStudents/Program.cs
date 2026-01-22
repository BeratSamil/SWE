using System;
using System.Collections.Generic;
using System.Linq;
namespace codes;


public class Student
{
    private string _name;
    private string _faculty;
    private int _grade;
    public static int countr = 0;

    public string _studentID;





    static int getNum()
    {
        Random random = new Random();
        int number;
        number = random.Next(0, 100);
        return number;
    }


    static int getRandomID()
    {
        Random random = new Random();
        int number;
        number = random.Next(999, 1500);
        return number;
    }





    public Student(string name, string faculty)
    {
        _name = name;
        _faculty = faculty;
        _grade = getNum();
        countr += 1;

    }

    public string name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string faculty
    {
        get { return _faculty; }
        set { _faculty = value; }
    }
    public int grade
    {
        get { return _grade; }
        set { _grade = value; }
    }


    public double calcAvgGra()
    {
        int avg = 0;
        for (int i = 0; i < countr; i++)
        {
            avg += grade;

        }
        avg = avg / 5;
        return avg;
    }


    public static void showStudents(List<Student> students)
    {
        for (int i = 0; i < students.Count; i++)
        {
            Console.WriteLine("{0} {1} {2}", students[i].name, students[i].faculty, students[i].grade);
        }



    }


    public static void CreateIDs(List<string> ids, int n)
    {
        int count=0;
        string piece="";

        
        while (count<n)
        {
            piece=getRandomID();
            if (ids.Contains(piece)==false)
            {
                ids.Add(piece);
                count++;
            }
        }
    }



}

class Program
{



    static void DeleteStd(List<Student> studentLst,string studentName )
    {
        for (int i = 0; i < studentLst.Count; i++)
        {
            if (studentLst[i].name==studentName)
            {
                studentLst.RemoveAt(i);
                Student.countr--;
            }
        }
    }







    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");


        List<Student> studLst = new List<Student>();
        int numOfstd = 5;

        for (int i = 0; i < numOfstd; i++)
        {
            Student std = new Student("student" + i, "Faculty of Eng");
            studLst.Add(std);

        }


        List<string> idList=new List<string>();
        CreateIDs(idList,numOfstd);



        Student.showStudents(studLst);
        Console.WriteLine($"We have {Student.countr} Students");
        double avg = 0;
        for (int i = 0; i < Student.countr; i++)
        {
            avg += studLst[i].grade;

        }
        avg = avg / 5;
        Console.WriteLine($"Average Grade is : {avg}");


        DeleteStd(studLst,"student0");


        for (int i = 0; i < studLst.Count; i++)
        {

        }



        var result = from x in studLst
                     orderby x.name
                     group x by x.name;


        foreach (Student x in studLst)
        {
            Console.WriteLine($"{x.name}, {x.grade}");
        }

        // studLst.Sort((x, y) => y.grade.CompareTo(x.grade));
        // Console.WriteLine(studLst[0].name + " has the highest grade: " + studLst[0].grade);

    }
}
