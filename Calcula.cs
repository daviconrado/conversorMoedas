using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ConversorMoedas
{
    public class Calcula
    {
        public static double Resultado(string resultadoBody, string valor)
        {
            string[] splitResult = resultadoBody.Split("\"");
            string high = splitResult[17];
            string highFormat = high.Replace(".", ",");
            double highNum = Convert.ToDouble(highFormat);
            double valorNum = Convert.ToDouble(valor);

            return valorNum * highNum;
        }
    }
}
