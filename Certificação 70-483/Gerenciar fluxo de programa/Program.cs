using Gerenciar_fluxo_de_programa.Objetivo_1._1___Implementar_processamento_multithreading_e_assíncrono.Using_Async_and_Await;
using Gerenciar_fluxo_de_programa.Objetivo_1._1___Implementar_processamento_multithreading_e_assíncrono.Using_Parallel_Class;
using Gerenciar_fluxo_de_programa.Objetivo_1._1___Implementar_processamento_multithreading_e_assíncrono.Using_PLINQ;
using Gerenciar_fluxo_de_programa.Objetivo_1._1___Implementar_processamento_multithreading_e_assíncrono.Using_Tasks;
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
            #region Thread

            // Básico sobre Thread
            // new ThreadClass().TestThread();

            // Thread em Background
            //new ThreadClass().ThreadBackground();

            // ParameterizedThreadStart
            //new ThreadClass().ParameterizedThreadStart();

            // ThreadStatic Attribute
            //new ThreadClass().ThreadStaticAttribute();

            // ThreadPool
            //new ThreadClass().ThreadPoolTeste();

            #endregion

            #region Tasks

            // Introdução a Task
            //new UsingTasks().StartTask();

            // Usando Task Gererics
            //new UsingTasks().GerenicTask();

            // Task Continue
            //new UsingTasks().TaskContinue();

            // Diferentes Continues
            //new UsingTasks().DiferentesContinues();

            // Child Tasks
            //new UsingTasks().ChildTasks();

            // WaitAll
            //new UsingTasks().WaitAll();

            // WaitAny
            //new UsingTasks().WaitAny();

            #endregion

            #region Parallel 

            // AggregateException

            // Exemplo Parallel
            //new ParallelClass().Exemplo();

            // Break and Stop
            //new ParallelClass().BreakAndStop();

            #endregion

            #region Async and Await

            // AggregateException

            //Exemplo Simples
            //new AsyncAndAwait().ExemploSimples();

            #endregion

            #region PLINQ

            //Exemplo Where
            //new Plinq().ExemploWhere();

            //Exemplo Sequencial
            //new Plinq().ExemploSequencial();

            //Exemplo ForAll
            //new Plinq().ExemploForAll();

            //Exemplo Exception
            new Plinq().ExemploException();

            #endregion
        }
    }
}
