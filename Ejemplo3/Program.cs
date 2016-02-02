using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Estudiante
{
    public string nombre = "";


    public Estudiante()
    {
        nombre = "";

    }

    public Estudiante(string nom)
    {
        nombre = nom;

    }
    public void SetParametros(string newName)
    {
        nombre = newName;

    }



}


class TestPerson
{
    static void Main()
    {

        Estudiante person1 = new Estudiante();
        Console.WriteLine(person1.nombre);
        person1.SetParametros("John Smith");
        Console.WriteLine(person1.nombre);

        Estudiante person2 = new Estudiante("Sarah Jones");
        Console.WriteLine(person2.nombre);
        Console.WriteLine("Pressanykeyto exit.");
        Console.ReadKey();
    }
}