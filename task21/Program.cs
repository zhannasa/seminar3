Console.WriteLine("Introduce coordenadas X1!");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Introduce coordenadas Y1!");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Introduce coordenadas Z1!");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Introduce coordenadas X2!");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Introduce coordenadas Y2!");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Introduce coordenadas Z2!");
int z2 = int.Parse(Console.ReadLine());

double answer = Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2) + (z1-z2)*(z1-z2));

Console.WriteLine(answer);
Console.WriteLine(Math.Round(answer,2));
