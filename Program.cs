using System;

class Program
{
    private const string PromptWidth = "Introdueix l'amplada del rectangle: ";
    private const string PromptHeight = "Introdueix l'altura del rectangle: {0}";
    private const string PromptResultArea = "L'àrea del rectangle és: ";
    private const string PromptRadius = "Introdueix el radi del cercle: ";
    private const string PromptCircumference = "La circumferència del cercle és: {0}";


    private const string ResultAreaBig = "L'àrea és més gran de 50";
    private const string ResultAreaMedium = "L'àrea és entre 20 i 50";
    private const string ResultAreaSmall = "L'àrea és menor o igual a 20";

    static void Main(string[] args)
    {
        // Sol·licita l'entrada de l'usuari per calcular l'àrea d'un rectangle
        Console.WriteLine(PromptWidth);
        double width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(PromptHeight);
        double height = Convert.ToDouble(Console.ReadLine());

        // Calcula l'àrea
        double area = CalculateArea(width, height);

        // Sol·licita l'entrada de l'usuari per calcular la circumferència d'un cercle
        double circumference = GetInputRadius();

        Console.WriteLine(PromptCircumference, circumference);

        // Imprimeix un missatge basat en el valor de l'àrea
        PrintArea(area);
    }

    private static void PrintArea(double area)
    {
        if (area > 50)
        {
            Console.WriteLine(ResultAreaBig);
        }
        else if (area > 20)
        {
            Console.WriteLine(ResultAreaMedium);
        }
        else
        {
            Console.WriteLine(ResultAreaSmall);
        }
    }

    private static double CalculateArea(double width, double height)
    {
        double area = width * height;
        Console.WriteLine(PromptResultArea, area);
        return area;
    }

    private static double GetInputRadius()
    {
        Console.WriteLine(PromptRadius);
        double radius = Convert.ToDouble(Console.ReadLine());
        double circumference = 2 * Math.PI * radius;
        return circumference;
    }
}