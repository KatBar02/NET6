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
using WpfApp1.Data;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class PersonDetail : Window
    {
        Person person;
        MainWindow mainWindow;
        bool isNewPerson = false;
       public PersonDetail(Person _person, MainWindow _mainWindow, bool _isNewPerson)
        {
            InitializeComponent();

            mainWindow = _mainWindow;
            isNewPerson = _isNewPerson;

            if (isNewPerson) //pokud nová osoby - vytvor prázdnu instanci osoby
                person = new Person();
            else 
                person = _person; //inak použi čo prišlo z MainWindow

            txtFirstName.Text = person.FirstName;
            txtLastName.Text = person.LastName;
            txtBirthDate.Text = person.Birthdate.ToShortDateString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            person.FirstName = txtFirstName.Text; 
            person.LastName = txtLastName.Text;

            if (isNewPerson)
                DataAccess.CreatePersnon(person);
            else
                DataAccess.SavePersonToDB(person);


            DataAccess.LoadPeopleFromDB();

            mainWindow.grdPeople.ItemsSource = DataAccess.people;
            mainWindow.btnDetailOsoby.IsEnabled = false;

            this.Close();
        }
    }
}
