System.Console.WriteLine("Привет");
System.Console.WriteLine("Введите число а");
int a = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите число c");
int c = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите число d");
int d = int.Parse(Console.ReadLine());

double Rezult(int a, int b, int c, int d)
{
    double rez = (a * b) ;
    int rez1= (c + d);
    double itog = rez/rez1;
   return itog;
    //System.Console.WriteLine(itog);

}
System.Console.WriteLine(Rezult(a,b,c,d));



