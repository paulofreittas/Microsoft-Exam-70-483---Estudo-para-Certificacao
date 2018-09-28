using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciar_fluxo_de_programa.Objetivo_1._1___Implementar_processamento_multithreading_e_assíncrono.Using_PLINQ
{
    public class Plinq
    {
        // É o uso de LINQ (Language Integrated Query) em System.Linq.ParallelEnumerable 
        // Métodos Where, Select, SelectMany, GroupBy, Join, OrderBy, Skip, e Take

        public void ExemploWhere()
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel().Where(i => i % 2 == 0).ToArray();

            foreach (int i in parallelResult)
                Console.WriteLine(i);

            Console.ReadKey();
        }

        public void ExemploSequencial()
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel().AsOrdered().Where(i => i % 2 == 0).AsSequential();

            foreach (int i in parallelResult.Take(5))
                Console.WriteLine(i);

            Console.ReadKey();
        }

        public void ExemploForAll()
        {
            var source = Enumerable.Range(100, 20000);

            // Result sequence might be out of order.
            var parallelQuery = from num in source.AsParallel()
                                where num % 10 == 0
                                select num;

            // Process result sequence in parallel
            parallelQuery.ForAll((e) => Console.WriteLine("count: " + e));

            // Or use foreach to merge results first.
            foreach (var n in parallelQuery)
            {
                Console.WriteLine(n);
            }

            // You can also use ToArray, ToList, etc as with LINQ to Objects.
            var parallelQuery2 = (from num in source.AsParallel()
                                  where num % 10 == 0
                                  select num).ToArray();

            // Method syntax is also supported
            var parallelQuery3 = source.AsParallel().Where(n => n % 10 == 0).Select(n => n);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }

        public void ExemploException()
        {
            var numbers = Enumerable.Range(0, 20);
            try
            {
                var parallelResult = numbers.AsParallel()
                .Where(i => IsEven(i));
                parallelResult.ForAll(e => Console.WriteLine(e));
            }
            catch (AggregateException e)
            {
                Console.WriteLine("There where {0} exceptions", e.InnerExceptions.Count);
            }

            Console.ReadKey();

        }

        public bool IsEven(int i)
        {
            if (i % 10 == 0) throw new ArgumentException();

            return i % 2 == 0;
        }
    }
}
