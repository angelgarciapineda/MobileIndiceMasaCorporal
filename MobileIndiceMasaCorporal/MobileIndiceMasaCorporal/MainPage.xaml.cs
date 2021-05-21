using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileIndiceMasaCorporal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Altura.Text) && !string.IsNullOrEmpty(Peso.Text))
            {
                var altura = double.Parse(Altura.Text);
                var peso = double.Parse(Peso.Text);
                var imc = peso / (altura * altura);
                IMC.Text = imc.ToString();

                string mensaje = "";
                if (imc < 18.5)
                {
                    mensaje = "Tienes bajo peso";
                }
                else if (imc >= 18.5 && imc <= 24.9)
                {
                    mensaje = "Tu peso es normal";
                }
                else if (imc >= 25 && imc <= 29.9)
                {
                    mensaje = "Cuidate más :)";
                }
                else
                {
                    mensaje = "Consulta a tu Nutriologo :)";
                }

                DisplayAlert("Resultado", mensaje, "OK");
            }
            else
            {
                DisplayAlert("Datos incorrectos", "Favor de ingresar los datos", "OK");
            }
        }
    }
}
