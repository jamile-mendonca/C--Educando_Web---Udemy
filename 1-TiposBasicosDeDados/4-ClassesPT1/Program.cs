using _4_ClassesPT1;
using System.Globalization;

Triangulo x, y;
x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Entre com as medidas do triangulo x");

x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Entre com as medidas do triangulo y");

y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


double areaX = x.Area();

double areaY = y.Area();

Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

if (areaX > areaY)
{
    Console.WriteLine("Maior área: X");
}
else
{
    Console.WriteLine("Maior área: Y");
}


Retangulo r = new Retangulo();
Console.WriteLine("Entre a largura e a altura do retangulo: ");
r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Área= " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Perimetro= " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Diagonal= " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

Console.Write("Entre o valor do raio: ");
double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double circ = Circulo.Circunferencia(raio);
double volume = Circulo.Volume(raio);


Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Valor de PI: " + Circulo.Pi.ToString("F2", CultureInfo.InvariantCulture));