using System;
using System.Runtime.InteropServices.JavaScript;

namespace App;

public class Program
{

    private int idade;
    private string name;
    private decimal altura;
    private new DateTime data;
    
    public static void Main(string[] args)
    {
        Program program = new Program();
        program.resultado();
        Console.WriteLine($"{program.name}");
        Console.WriteLine($"{program.idade}");
        Console.WriteLine($"{program.altura}");
        Console.WriteLine($"{program.data}");
    }

    public void resultado()
    {
        this.idade = 23;
        this.altura = 1.70m;
        this.name = "Vitor";
        this.data = new DateTime(2001,04,03);
    }
}

