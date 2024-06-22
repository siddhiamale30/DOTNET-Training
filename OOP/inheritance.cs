using System;

class Animal{
    public string name;
    // public Animal(string n){
    //     this.name=n;
    // }

    public void eat(){
        Console.WriteLine(name+" Animal Likes to Eat ....!!!");
    }
}

class Bird : Animal{
public void eat(){
    Console.WriteLine(name+" Bird Eats Regularly...!");
}
}

class cls{
    public static void Main(string[] args){
        Animal o=new Animal();
        o.name="Elephant";
        o.eat();

        Bird b=new Bird();
        b.name="Sparrow";
        b.eat();
    }
}