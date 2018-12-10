using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    protected class Students{
        public string name{ get; set;}
        public int grade{ get; set;}
        public Students(string name, int grade){
            this.name=name;
            this.grade=grade;
        }
    }
    List<Students> studentsList;
    public GradeSchool(){
        studentsList=new List<Students>();
    }
    public void Add(string student, int grade)
    {
        studentsList.Add( new Students(student,grade) );
    }

    public IEnumerable<string> Roster()
    {   
        List<string> result= new List<string>();

        IEnumerable<Students> sortedList=studentsList.OrderBy(student => student.grade).ThenBy(student => student.name);

        foreach(var s in sortedList){
            result.Add(s.name);
        }

        return result;
    }

    public IEnumerable<string> Grade(int grade)
    {
        var result=new List<string>();
        foreach(var student in studentsList){
            if(student.grade==grade){
                result.Add(student.name);
            }
        }

        result.Sort();
        return result;
    }
}