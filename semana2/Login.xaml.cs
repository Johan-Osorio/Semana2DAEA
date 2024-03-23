using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace semana2
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        static string usuario = "Johan Osorio";
        static string contraseña = "3118";

        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (
                textbox_usuario.Text.Equals(usuario) &&
                textbox_contraseña.Text.Equals(contraseña)
                )
            {
                MessageBox.Show("Se inició correctamente");
            }
            else
            {
                MessageBox.Show("Error con las credenciales");
            }

            Menu menu = new Menu();
            menu.Show();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void textbox_usuario_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textbox_contraseña_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
