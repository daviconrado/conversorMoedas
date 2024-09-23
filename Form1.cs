using System.Configuration;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace ConversorMoedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            double numero;
            bool ehNumero = double.TryParse(valor1.Text, out numero);
            int eFlag = 0;
            if (valor1.Text == "")
            {
                exibeResultado.Text = "Insira um valor";
                eFlag = 1;
            }
            else if (moeda1.SelectedItem == moeda2.SelectedItem) {
                exibeResultado.Text = "As moedas devem ser diferentes";
                eFlag = 1;
            }
            else if (!ehNumero)
            {
                exibeResultado.Text = "Digite um número válido";
                eFlag = 1;
            }
            else if (valor1.Text.Contains("."))
            {
                exibeResultado.Text = "O número deve ser separado por vírgula";
                eFlag = 1;
            }

            if (eFlag == 0) {
                string valor = valor1.Text;
                string Moeda1 = moeda1.SelectedItem.ToString();
                string Moeda2 = moeda2.SelectedItem.ToString();
                exibeResultado.Text = "Carregando...";
                double resultado = Calcula.Resultado(await ConnectionAPI.Main(Moeda1, Moeda2), valor);
                mostraResultado(resultado, Moeda1, Moeda2);
            }
        }

        public void mostraResultado(double valor, string moeda1, string moeda2)
        {
            string resultado = string.Format("O valor de {0} para {1} é: {2:F3}",moeda2,moeda1,valor);
            exibeResultado.Text = resultado;
        }
    }
}
