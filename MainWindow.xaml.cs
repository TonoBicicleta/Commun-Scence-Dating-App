using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing; 

namespace Projecto_Tono
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int Max_Age = 55;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            popo_duda.Opacity = 0.0;
            int age;
            if (int.TryParse(TextBox_Edad.Text, out age))
            {
           
                Console.WriteLine($"La edad ingresada es: {age}");
                
            }
            else
            {
               
                MessageBox.Show("Cabron es edad no un parrafo lamao.");
            }

            

            if (age == 0)
            {

                popo_duda.Content = "Necesitas ayuda sicologica";
                popo_duda.Opacity = 1.0;
                popo_duda.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));

            }
            else if (age > 1 && age < 18)
            {
                
                popo_duda.Content = "Vas Preso Cb";
                popo_duda.Opacity = 1.0;
                popo_duda.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0));

            }
            else if (age >= 18 && age < Max_Age)
            {

                popo_duda.Content = "Cb Esta Pasable y lo mejor que es mayor de edad.";
                popo_duda.Opacity = 1.0;
                popo_duda.Foreground = new SolidColorBrush(Color.FromRgb(37, 181, 24));
                
            }
            else if (age >= Max_Age)
            {
                
                popo_duda.Content = "Con Cuidao' it may be dry.";
                popo_duda.Opacity = 1.0;
                popo_duda.Foreground = new SolidColorBrush(Color.FromRgb(181, 139, 24));

            }

        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/VdN9qwDnzC");
        }

        
    }
}
