using System;

namespace AreaMethodTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please ,input radius");
            
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine("Overload 1:Cevrenin Sahesi");
            Console.WriteLine(area(r));
            Console.WriteLine("please  Duzbucaqlinin tereflerini daxil edin");
            int a = Convert.ToInt32(Console.ReadLine());
            int b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Overload 2: Duzbucaqlinin sahesi ");
            Console.WriteLine(area(a,b));
            Console.WriteLine("please Paralapepidin tereflerini daxil edin");
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("Overload 3:Paralapepidin sahesi");
            Console.WriteLine(area(c, d, e));
            Console.WriteLine("please ucbucagin tereflerini daxil edin");
            Console.WriteLine("Overload 4:Ucbucaqin daxiline cekilmis cevrenin sahesi");
            
            int f = Convert.ToInt32(Console.ReadLine());
            int g = Convert.ToInt32(Console.ReadLine());
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(area(r,f,g,h));





        }
        static  float area(float r,int p=3)
        {   
            float S = p * (r * r);
            return S;
        }
        static int area(int a,int b)
        {
            int S = a * b;
            return S;
        }
        static int area(int c,int d,int e)
        {
            int S = 2*(d * e + d * c + e * c);
            return S;
        }
        static float area(float r,int f,int g ,int h)
        {
           int  pre = (f + g + h) / 2;
            float S = pre * r;
            return S;
           
        }
    }
}
