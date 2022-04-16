using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DashboardLogistico.Data;
using DashboardLogistico.Core;
using DashboardLogistico.Core.Models;
using System.Threading;

namespace TesteRapidoDashboard
{
    class Program
    {
        static void Main(string[] args)
        {

            ConfigGlobal configGlobal = new ConfigGlobal();

            configGlobal.CaminhoBaseDados = @"C:\Temp\save.sqlite";

            DBConnection dBConnection = new DBConnection(configGlobal.CaminhoBaseDados);

            IProgress<NotaFiscal> progress = new Progress<NotaFiscal>();


            NotaFiscalRepository notaFiscalRepository = new NotaFiscalRepository(configGlobal, dBConnection);

            IEnumerable<NotaFiscal> notas = notaFiscalRepository.GetNotasCSVAsync(@"C:\Temp\teste.csv", progress, CancellationToken.None).Result;

            Console.WriteLine("Quantidade de notas: " + notas.Count());

            IProgress<NotaFiscal> progressSave = new Progress<NotaFiscal>();

            notaFiscalRepository.SaveNotasAsync(notas, progressSave, CancellationToken.None).Wait();

            Console.WriteLine("Documento Salvo");

            var notasJson = notaFiscalRepository.GetNotasAsync().Result;

            Console.WriteLine("Leitura feita json: " + notasJson.Count());

            Console.ReadLine();


        }
    }
}
