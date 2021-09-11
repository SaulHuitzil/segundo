using System;

namespace mensajes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Este es el primer mensaje");
            Console.WriteLine("Este es el segundo mensaje");
            T01();
        }

        static void T01() {
          for (int i = 0; i < 10; i++) {
            Console.WriteLine($"El valor de i es {i}");
          }
        }
    }
}
