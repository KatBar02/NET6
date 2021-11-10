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
using System.Windows.Navigation;
using System.Windows.Shapes;
using HelloWorldCore.Model;

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("klik!");
            
            textVyselek.Text = Hello(textJmeno.Text);
        }

        static string Hello(string name)
        {
            string name5p = name;

            if (name == "Lukáš")
            {
                name5p = "Lukáši";
            }
            else if (name == "Karel")
            {
                name5p = "Karle";
            }
            else if (name == "Petr")
            {
                name5p = "Petře";
            }
            else
            {
                name5p += ", omlouvám se, ale tvoje jméno neumím skloňovat.";
            }

            return "Ahoj " + name5p;
        }

        private void btnDetailOsoby_Click(object sender, RoutedEventArgs e)
        {
            Person p = new Person();
            p.FirstName = "Alice";
            p.LastName = "Smith";
            p.Birthdate = new DateTime(2020,01,01);
            PersonDetail pdwindow = new PersonDetail(p);
            pdwindow.Show();

        }
    }
}
