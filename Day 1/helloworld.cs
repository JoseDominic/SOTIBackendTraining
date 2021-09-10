using System;
public class MyClass
{
	public string myField = string.Empty;
	
	public MyClass()
	{}
	
	public void MyMethod(int parameter1,string parameter2)
	{
		Console.WriteLine("First Parameter {0}, second parameter {1}",parameter1, parameter2);	
	}
	
	public int myAutoImplementedProperty { get;set;}
	
	private int myPropertyVar;
	
	public int myProperty
	{
		get{ return myPropertyVar; }
		set { myPropertyVar = value; }
	}
	
	public static void Main(String []args){
		Console.WriteLine("Hello World");
		MyClass c1 = new MyClass();
		c1.myPropertyVar = 20;
		Console.WriteLine(c1.myPropertyVar);
	}
}