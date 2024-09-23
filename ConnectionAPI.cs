using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;


namespace ConversorMoedas
{
    public class ConnectionAPI
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> Main(string moeda1, string moeda2)
        {
            if(moeda1 == "Real (BRL)")
            {
                moeda1 = "BRL";
            }
            else if(moeda2 == "Real (BRL)")
            {
                moeda2 = "BRL";
            }

            if (moeda1 == "Dólar Americano (USD)")
            {
                moeda1 = "USD";
            }
            else if (moeda2 == "Dólar Americano (USD)")
            {
                moeda2 = "USD";
            }

            if (moeda1 == "Euro (EUR)")
            {
                moeda1 = "EUR";
            }
            else if (moeda2 == "Euro (EUR)")
            {
                moeda2 = "EUR";
            }

            string url = $"https://economia.awesomeapi.com.br/last/{moeda1}-{moeda2}";

            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                response.EnsureSuccessStatusCode();


                string responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("Erro ao enviar a requisição:");
                return e.Message;
            }
        }

    }
}
