using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gerenciar_fluxo_de_programa.Objetivo_1._1___Implementar_processamento_multithreading_e_assíncrono.Using_the_Thread_class
{
    public class ThreadClass
    {
        /* 
         IMPORTANTE: 
         
         Você pode definir a prioridade de execução de uma thread, mas só é recomendado fazer isso quando realmente for preciso. 
         Por padrão toda nova thread é iniciada com prioridade normal.

         Foreground Thread - São usadas para manter sua aplicação executando. A aplicação só será fechada quando todas as foreground threads tiverem terminado sua execução.

         Background Thread - São finalizadas imediatamente quando a sua thread principal é finalizada.

         Por padrão uma nova thread é iniciada em modo Foreground.

         Para finalizar um thread posso utilizar o Thread.Abort porém a thread pode estar em meio de algum processo que gere uma ThreadAbortException
        */

        [ThreadStatic]
        public static int _field = 0;

        public void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(2000);
            }
        }

        public void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }

        public void TestThread()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Thread Principal Executando");
                Thread.Sleep(1000);
            }

            // O Join é utilizado para esperar que a thread termine sua execução para prosseguir.
            t.Join();

            // Essa linha só será executada quando a Thread t terminar sua execução.
            // Se o t.Join() for retirado essa linha será executada simultâneamente com Thread t.
            Console.WriteLine("Passou aqui!");

        }

        public void ThreadBackground()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.IsBackground = true;
            t.Start();
        }

        public void ParameterizedThreadStart()
        {
            // Usado para passar um parametro para a thread, veja que no t.Star está sendo passado o objeto 5
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(5);
            t.Join();
        }

        public void ThreadStaticAttribute()
        {
            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("Thread A: {0}", _field);
                }
            }).Start();

            new Thread(() =>
            {
                for (int x = 0; x < 10; x++)
                {
                    _field++;
                    Console.WriteLine("Thread B: {0}", _field);
                }
            }).Start();

            Console.ReadKey();
        }

        public void ThreadPoolTeste()
        {
            // Cria uma fila de execução para as threads, porém você não tem controle de quando serão executadas.
            // A Microsoft recomenda usar Task para gerencias a ThreadPool.
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from threadpool");
            });
            Console.ReadLine();
        }

    }
}
