using System;
namespace today
{
class person
{
	public string name;
	public  person(string name)
	{
		this.name=name;
	}
	public override string ToString()
	{
		return name;	
	}
}
class student:person
{
	public student(string name):base(name) {}
	
	public void study()
	{
		Console.WriteLine("the student " +name+" is studying");	
	}
}
class teacher:person
{
	public teacher(string name):base(name) {}
	public void explain()
	{
		Console.WriteLine("the teacher " +name+" is explaining");
	}
}
public class main
{
	public static void Main(string[]args)
	{
		student s1=new student("ravi");
		s1.study();
		teacher t1=new teacher("seema");
		t1.explain();
		person p1=new person("person");
		Console.WriteLine(p1.ToString());
		
	}
}
}