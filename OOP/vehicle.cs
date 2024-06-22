using System;
class student{
    public int roll;
    public string name;
    public string clg;
    public int age;
    public student(int r,string n,string c,int a){
        this.roll=r;
        this.name=n;
        this.clg=c;
        this.age=a;
    }

    public void fun(){
        Console.WriteLine("Student Information : \nRoll Number :"+roll+"\nName :"+name+"\nCollege :"+clg+"\nAge :"+age);
    }
    public static void Main(string[] args){
        student o=new student(4,"Siddhi Amale","SCOE",20);
        o.fun();
    }
}