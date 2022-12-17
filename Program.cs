using System;
namespace task;
    class  abstract person{
       public string name;
       public int age;
      public person ( string _name , int _age){
        name = _name;
        age = _age;
       }
       public abstract void print(){

        }
    }
        class student : person{
        public int year;
        public float gpa;
        public student( string _name , int _age , int _year , float _gpa) : base(_name , _age){
            year = _year;
            gpa = _gpa;
        }
        public override void print(){
            Console.WriteLine("My name is " + name + "My age is " + age +"and my gpa is " + gpa);
        }
        }
        public class database{
        private int _currentIndex;
        public person[] people = new person[50];

        public void addstudent(student stu){
            people[_currentIndex++] = stu;
        }
        public void addstaff(staff staf){
            people[_currentIndex++] = staf;
        }

      }
    class staff : person{
        public double salary;
        public int joinyear;
        public staff(double _salary , int _joinyear) : base(_name , _age){
            salary = _salary;
            joinyear = _joinyear;
        }
        public override void print(){
            Console.WriteLine("My name is " + name + "My age is " + age +"and my salary is " + salary);
        }
    }
     public class task1{
       public static void Main(){
        var data = new database();
        Console.WriteLine("Name: ");
        var Name = Console.ReadLine();
        Console.WriteLine("Age: ");
        var Age =Convert.ToInt32( Console.ReadLine());
        Console.WriteLine("Year: ");
        var Year = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Gpa: ");
        var Gpa = Convert.ToSingle(Console.ReadLine());
        var stud = new student(Name , Age , Year , Gpa);

    }
    }