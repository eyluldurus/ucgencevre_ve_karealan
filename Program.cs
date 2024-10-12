using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

int kenar1; int kenar2; int kenar3; int cevre; double kenar; double alan; 

Console.WriteLine("birinci kenar değeri gir");
kenar1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("ikinci kenar değeri gir");
kenar2 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("üçüncü kenar değeri gir");
kenar3 = Convert.ToInt32 (Console.ReadLine());

cevre = (kenar1 + kenar2 + kenar3);
Console.WriteLine("Üçgenin çevresi:" + cevre);


Console.WriteLine ("karenin bir kenar uzunluğunu girin");
kenar = Convert.ToDouble(Console.ReadLine());

alan = kenar * kenar;
Console.WriteLine("Karenin alanı:" + alan);
