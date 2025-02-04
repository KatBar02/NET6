﻿using System;
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
using HelloWorldCore.Data;
using WpfApp1.Data;

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
            
            //textVyselek.Text = Hello(textJmeno.Text);
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
            var p = (Person)grdPeople.SelectedItem; //SelectedItem vrací objekt typu person, preto je to ok pretypovaŤ na Person
            PersonDetail pdwindow = new PersonDetail(p, this, false);
            pdwindow.ShowDialog();

        }

        private void wMain_Loaded(object sender, RoutedEventArgs e)
        {
            //string dir = @"C:\Users\barto\source\repos\skolenie\HelloWorldCore\HelloWorldCore\bin\Debug\net5.0\";
            //string filepath = System.IO.Path.Combine(dir + "people.txt");
            //var people = PersonData.LoadPerson(filepath);

            DataAccess.LoadPeopleFromDB();
            grdPeople.ItemsSource = DataAccess.people;

            //LoadInitialDataset();
        }

        private void grdPeople_SelectionChanged(object sender, SelectionChangedEventArgs e) 
            // na vybranie v DataGrit sa tlačítlko zprístupní, pred tým nastaviť v jeho vlastnostiach Enabled = false
        {
            btnDetailOsoby.IsEnabled = true;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PersonDetail pdwindow = new PersonDetail(null, this, true);
            pdwindow.ShowDialog();
        }

        

        private void txtFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            string filtertext = txtFilter.Text.ToLower();

            if (!string.IsNullOrEmpty(filtertext))
            {
                var filteData = DataAccess.people
                    .Where(x => x.FirstName.ToLower().Contains(filtertext) 
                             || x.LastName.ToLower().Contains(filtertext));
                grdPeople.ItemsSource = filteData;
            }
            else
            {
                grdPeople.ItemsSource = DataAccess.people;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            txtFilter.Text = "";
            grdPeople.ItemsSource = DataAccess.people;
        }

        private void grdPeople_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyName == "Cars") //nad stĺpčekom Cars
            {
                e.Cancel = true; // stlpšek Cars sa negeneruje
            }
        }




        //private void LoadInitialDataset ()
        //{
        //    using(var db = new PeopleContext()) //
        //    {
        //        string dir = @"C:\Users\barto\source\repos\skolenie\HelloWorldCore\HelloWorldCore\bin\Debug\net5.0\";
        //        string filepath = System.IO.Path.Combine(dir + "people.txt");
        //        var people = PersonData.LoadPerson(filepath);

        //        db.People.AddRange(people); // uložené v pamati pc
        //        db.SaveChanges(); //uloženie do dtb do všetkých tabuliek
        //    }
        //}
    }
}
