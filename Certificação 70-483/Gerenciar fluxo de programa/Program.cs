using Gerenciar_fluxo_de_programa.Objetivo_1._1___Implementar_processamento_multithreading_e_assíncrono.Using_the_Thread_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciar_fluxo_de_programa
{
    class Program
    {
        static void Main(string[] args)
        {
            // Básico sobre Thread
            // new ThreadClass().TestThread();

            // Thread em Background
            //new ThreadClass().ThreadBackground();

            // ParameterizedThreadStart
            //new ThreadClass().ParameterizedThreadStart();

            // ThreadStatic Attribute
            //new ThreadClass().ThreadStaticAttribute();

            // ThreadPool
            new ThreadClass().ThreadPoolTeste();
        }
    }
}
