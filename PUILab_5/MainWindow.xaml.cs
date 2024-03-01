using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace PUI_lab5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public CapitalList capitalList = new CapitalList();

        public MainWindow()
        {
            InitializeComponent();
            dgridCapitals.ItemsSource = capitalList.Items;
        }

        private void btLoadXML_Click(object sender, RoutedEventArgs e)
        {
            var formatter = new XmlSerializer(typeof(CapitalList));
            var fs = new FileStream("Resources\\data.xml", FileMode.OpenOrCreate);
            capitalList = (CapitalList)formatter.Deserialize(fs);
            dgridCapitals.ItemsSource = capitalList.Items;
        }

        private void btSaveAsXML_Click(object sender, RoutedEventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(CapitalList));
            FileStream fs = new FileStream("Resources\\data.xml", FileMode.OpenOrCreate);
            formatter.Serialize(fs, capitalList);
            fs.Close();
        }

        private void btClearTable_Click(object sender, RoutedEventArgs e)
        {
            capitalList.Items.Clear();
            dgridCapitals.ItemsSource = null;
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            Capital capital = new Capital();
            capital.Country = tbCountry.Text;
            capital.Name = tbCapital.Text;
            capital.PartOfTheWorld = tbPartOfTheWorld.Text;
            capital.Population = tbPopulation.Text;
            capital.Area = tbArea.Text;
            capitalList.Items.Add(capital);
            dgridCapitals.ItemsSource = null;
            dgridCapitals.ItemsSource = capitalList.Items;
        }

        private void btChange_Click(object sender, RoutedEventArgs e)
        {
            foreach (Capital capital in capitalList.Items)
            {
                if (capital.Country == tbCountry.Text)
                {
                    capital.Name = tbCapital.Text;
                    capital.Country = tbCountry.Text;
                    capital.PartOfTheWorld = tbPartOfTheWorld.Text;
                    capital.Population = tbPopulation.Text;
                    capital.Area = tbArea.Text;
                    break;
                }
            }
            dgridCapitals.ItemsSource = null;
            dgridCapitals.ItemsSource = capitalList.Items;
        }

        private void btDelete_Click(object sender, RoutedEventArgs e)
        {
            foreach(Capital capital in capitalList.Items)
            {
                if(capital.Name == tbCapital.Text)
                {
                    capitalList.Items.Remove(capital);
                    break;
                }
            }
            dgridCapitals.Items.Refresh();
            clearAllTextBox();
        }

        private void clearAllTextBox()
        {
            tbCountry.Text = "";
            tbCapital.Text = "";
            tbPartOfTheWorld.Text = "";
            tbPopulation.Text = "";
            tbArea.Text = "";
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            Capital capital = dgridCapitals.SelectedItem as Capital;
            tbCapital.Text = capital.Name;
            tbCountry.Text = capital.Country;
            tbPartOfTheWorld.Text = capital.PartOfTheWorld;
            tbPopulation.Text = capital.Population;
            tbArea.Text = capital.Area;
        }
    }
}
