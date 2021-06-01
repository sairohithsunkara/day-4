using System;
class Mul {
    public int number1,number2;
    public Mul(int number1,int number2) {
        this.number1=number1;
        this.number2=number2;
    }
   public static Mul operator *(Mul m1,Mul m2) {
       Mul m3 = new Mul(0,0);
       m3.number1=m1.number1*m2.number1;
       m3.number2=m1.number2*m2.number2;
       return m3;
   }
}
class ObjectMul {
    public static void Main() {
        Mul m1 = new Mul(2,3);
        Mul m2 = new Mul(4,9);
        Mul m3 = new Mul(0,0);
        Console.WriteLine("Values before mul number 1:"+m3.number1+" Number 2 "+m3.number2);
        m3=m1*m2;
        Console.WriteLine("Values after mul number 1:"+m3.number1+" Number 2 "+m3.number2);
    }
}