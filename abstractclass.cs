namespace ABSTRACT_CLASS
{
    abstract class person{
        public string name;
        public int age;
        public string PhoneNumber;

        public abstract void PrintDetails();



    }

    class Student:person{

        public int rollnum;
        public int fees;
        public override void PrintDetails()
        {
           Console.WriteLine("Student Name is {0}",name);
 Console.WriteLine("Student Rollnum  is {0}",rollnum);
  Console.WriteLine("Student fees is {0}",fees);
        }



    }

    class Teacher :person{
        public string sub;
        public  int salary;

        public override void PrintDetails()
        {
               Console.WriteLine("teacher Name is {0}",name);
 Console.WriteLine("teacher subject  is {0}",sub);
  Console.WriteLine("teacher salary is {0}",salary);
        }
    }

    

}