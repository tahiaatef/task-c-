using System;
namespace task;
    class  person{
        private string _name;   
        public string Name 
            {
                get 
                    {
                       return _name;
                    } 
               set
                 {
                      if(value == null || value=="" || value.Length>=32)
                                   {
                                          throw new Exception("invalid name");
                                   } 
               _name=value;
                        }
            }
       private int _Age;
       public Person(string name,int age)
              {
                       if(name == null || name=="" || name.Length>=32)
                                   {
                                           throw new Exception("invalid name");
                                   } 
                       if (age<=0 ||age>=128){
                                     Console.WriteLine("invalid age");
                                        return;
                                             } 
                        Name=name;
                        _Age =age;
                                  }
 
       public int Getage() =>_Age;
 
 
      public virtual  void Print()
      {
      Console.WriteLine($"My name is {Name}, my age is {_Age}");
      }

}

class student : person (){
    private int _Year;
    public int Year
                     {
                         get 
                             {
                                return _Year;
                             } 
                         set
                               {
                                  _Year=value;
                               }   
                      }
    private float _Gpa;
    public float Gpa
               {
                    get 
                          {
                              return _Gpa;
                          } 
                   set
                           {
                              _Gpa=value;
                           }      
                }
    public Student(string name,int age,int year,float gpa ):base(name, age)
        {
            if (year<1 ||year>5)
               {
                 throw new Exception("invalid year");
               }
           if(gpa<0 ||gpa>4)
              {
               throw new Exception("invalid gpa");
              }
            Year=year;
            Gpa=gpa; 
        }
    public override void Print()
         {
        Console.WriteLine($"my name is{Name},my age is {Getage()},and my gpa is{Gpa}");
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
   
      
