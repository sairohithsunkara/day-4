using System;
class Program {
    int a=5,b=6;
    public void mul() {
        Console.WriteLine(a*b);
    }
    public int mul(int a,int b) {
        return(a*b);
    }
    public void mul(int a,int b,int c) {
        Console.WriteLine(a*b*c);
    }
    public void mul(string a,string b) {
        Console.WriteLine(a+b);
    }
}
class Overloading {
    public static void Main() {
        Program p = new Program();
        p.mul();
        Console.WriteLine(p.mul(10,20));
        p.mul(10,10,10);
        p.mul("Hello","World");
    }
}