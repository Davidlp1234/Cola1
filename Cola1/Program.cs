using System;
using System.Collections;
namespace Cola1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Queue miCola = new Queue();
            miCola.Enqueue("LULU");
            miCola.Enqueue("LOLO");
            miCola.Enqueue("LALa");

            

            foreach (string palabras in miCola)
                Console.WriteLine("{0}", palabras);
            Console.WriteLine("----------");
            Console.WriteLine("Dequeue: {0}", miCola.Dequeue());
            Console.WriteLine("Dequeue: {0}", miCola.Dequeue());
            Console.WriteLine("Dequeue: {0}", miCola.Dequeue());

            Console.WriteLine("----------");

            miCola.Enqueue("Ceresa");
            miCola.Enqueue("Zanahoria");
            miCola.Enqueue("Mango");

            Console.WriteLine("El peek: {0}", miCola.Peek());
            foreach (string fruta in miCola)
                Console.WriteLine("{0}", fruta);
            Console.WriteLine("--------------");
            Console.WriteLine("Cantidad de Elementos : {0}", miCola.Count);

            Console.ReadKey();
            
            
           
            
        }
    }
}
