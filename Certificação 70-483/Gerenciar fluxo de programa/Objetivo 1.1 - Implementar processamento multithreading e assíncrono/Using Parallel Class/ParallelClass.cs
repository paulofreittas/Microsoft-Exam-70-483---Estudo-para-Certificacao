using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gerenciar_fluxo_de_programa.Objetivo_1._1___Implementar_processamento_multithreading_e_assíncrono.Using_Parallel_Class
{
    public class ParallelClass
    {
        // Possui três metódos estáticos básicos (for, foreach e invoke) é recomendada quando se tem um loop muito grande e pode ser executado em paralelo.

        public void Exemplo()
        {
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine("For");
                Thread.Sleep(10000);
            });

            var numbers = Enumerable.Range(0, 10);

            Parallel.ForEach(numbers, i =>
            {
                Console.WriteLine("Foreach");
                Thread.Sleep(10000);
            });

            Console.ReadKey();
        }

        public void BreakAndStop()
        {
            // O Break garante que as iterações que estiverem sendo executadas no momento vão terminar sua execução e o Stop apenas termina tudo.

            ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) =>
            {
                Console.WriteLine("teste");

                if (i == 500)
                {
                    Console.WriteLine("Breaking loop");
                   // loopState.Break();
                    loopState.Stop();
                }
                return;
            });

            Console.ReadKey();
        }
    }
}
