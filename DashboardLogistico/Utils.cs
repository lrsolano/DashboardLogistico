using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardLogistico
{
    internal static class Utils
    {
        static public string EncodeToBase64(string texto)
        {
            byte[] textoAsBytes = Encoding.ASCII.GetBytes(texto);
            string resultado = System.Convert.ToBase64String(textoAsBytes);
            return resultado;
        }

        static public string DecodeFrom64(string dados)
        {
            byte[] dadosAsBytes = System.Convert.FromBase64String(dados);
            string resultado = System.Text.ASCIIEncoding.ASCII.GetString(dadosAsBytes);
            return resultado;
        }

        static string GenTimeSpanFromHours(double hours)
        {
            // Create a TimeSpan object and TimeSpan string from 
            // a number of hours.
            TimeSpan interval = TimeSpan.FromHours(hours);
            string timeInterval = interval.ToString();

            // Pad the end of the TimeSpan string with spaces if it 
            // does not contain milliseconds.
            int pIndex = timeInterval.IndexOf(':');
            pIndex = timeInterval.IndexOf('.', pIndex);
            if (pIndex < 0) timeInterval += "        ";

            return string.Format("{0,21}{1,26}", hours, timeInterval);
        }
    }
}
