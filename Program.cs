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
