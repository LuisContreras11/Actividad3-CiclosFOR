using System;

namespace Ciclos_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Crear un ciclo donde el usuario escoga donde inicia, termina y de cuanto en cuanto ira");
            Console.WriteLine("De donde empezara el ciclo? ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Donde acabara el ciclo? ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("De cuanto en cuanto ira el ciclo? ");
            z = int.Parse(Console.ReadLine());
            if(x>y)
            {
                for (int i=x;i>y;i-=z)
                {
                    Console.WriteLine("i= " + i);
                }
            }
            else
            {
                for(int i=x;i<y;i+=z)
                {
                    Console.WriteLine("i= " + i);
                }
            }
        }
    }
}
