using System;

public class Car{
    public Car(){

    }

    private string maker;
    private string model{ get; set;}
    private string engine{ get; set;}
    private string power {get; set; }
    private int price{ get; set; }
    private string prop6{ get; set; }
    private int prop7{ get; set; }
    private int prop8{ get; set; }
    public string prop9{ get; set; }
    public string prop10{ get; set; }

    public static void Main(string[] args) {
        Console.WriteLine("Success");
		Car ford = new Car();
		ford.maker = "ford";
		Console.WriteLine("Maker:{0}",ford.maker);
    }
    
}