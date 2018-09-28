using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciar_fluxo_de_programa.Objetivo_1._1___Implementar_processamento_multithreading_e_assíncrono.Using_Async_and_Await
{
    public class AsyncAndAwait
    {
        // Também pode usar o .configurateAwait(false) para evitar travar a thread principal esperando resposta da Task.

        public void ExemploSimples()
        {
            var html = DownloadContent().Result;
            Console.WriteLine(html);
            Console.ReadKey();
        }


        public async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://www.microsoft.com/pt-br");
                return result;
            }
        }
    }
}
