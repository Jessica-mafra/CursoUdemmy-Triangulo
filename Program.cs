using System.Globalization;
using CursoUdemmy2;
{
    Triangulo x, y;
    x= new Triangulo();
    y= new Triangulo(); 

    Console.Write("Entre com as medidas do triângulo X:");
    x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Eentre com as medidas do triângulo Y:");
    y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
     y.B= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


    double areaX = x.Area();// classe atribuida triangulo

    double areaY = y.Area();//classe atribuida triangulo

    Console.WriteLine("Àrea de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
    Console.WriteLine("Àrea de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

    if (areaX > areaY)
    {
        Console.WriteLine("Maior àrea: X");
    }
    else
    {
        Console.WriteLine("Maior àrea : Y");
    }
}