using System.Security.Cryptography.X509Certificates;

class Employee{
    public int EmpId;
    public string EmpName;
    public double Grosspay;

    double taxdeduction=0.1;
    double netSalary;

                public Employee(int eid,String enam,double gropro){
        this.EmpId=eid;
        this.EmpName=enam;
        this.Grosspay=gropro;

    }

    void salary(){

        if(Grosspay<30000){
            netSalary = Grosspay-(taxdeduction-Grosspay) ;
            Console.WriteLine("your net salary is {0}",netSalary);
        }
        else{
            Console.WriteLine("your net salary is {0}",Grosspay);
        }

        
    }
    public void salarycal(){
        this.salary();

    }
}

class EProgram{

    public static void Main(string[] args){
        Employee sagar = new Employee(1,"Sagar Adhikari",400000);
        sagar.salarycal();
        Console.ReadLine();


    }
}