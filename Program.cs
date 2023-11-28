using ABSTRACT_CLASS;

class EProgram{

    public static void Main(string[] args){
        // Employee sagar = new Employee(1,"Sagar Adhikari",400000);
        // sagar.salarycal();
        // Console.ReadLine();
        Student sagar =new Student();
        sagar.name="sagar adhikari";
        sagar.fees=56000;
        sagar.age=21;
        sagar.PhoneNumber="9808850889";
        sagar.rollnum=9;

        Teacher ram=new Teacher();
        ram.age=27;
        ram.name="ram hari";
        ram.PhoneNumber="9812312312";
        ram.salary=12344;
        ram.sub="english";
        


   sagar.PrintDetails();
   Console.WriteLine();
   ram.PrintDetails();
 

    }

 

}