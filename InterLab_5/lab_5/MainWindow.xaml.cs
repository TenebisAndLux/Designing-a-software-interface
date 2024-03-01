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

namespace lab_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public BookList bookList = new BookList();
        public MainWindow()
        {
            InitializeComponent();

            dgridBook.ItemsSource = bookList.Items;
        }

        private void LoadFromXML(object sender, RoutedEventArgs e)
        {
            var formatter = new XmlSerializer(typeof(BookList));
            var fs = new FileStream("Resources\\data.xml", FileMode.OpenOrCreate);
            bookList = (BookList)formatter.Deserialize(fs);
        }

        private void SaveToXML(object sender, RoutedEventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(BookList));
            FileStream fs = new FileStream("Resources\\data1.xml", FileMode.OpenOrCreate);
            formatter.Serialize(fs, bookList);
            fs.Close();
        }

        private void ClearDataGrid(object sender, RoutedEventArgs e)
        {
            dgridBook.ItemsSource = null;
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            dgridBook.Items.RemoveAt(dgridBook.SelectedIndex);
            dgridBook.CancelEdit();
            dgridBook.Items.Refresh();
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            dgridBook.Items.Insert(dgridBook.SelectedIndex, new Book
            {
                Autor = tbAutor.Text,
                Name = tbName.Text,
                Year = tbYear.Text,
                IZD = tbIZD.Text,
                Janr = tbJanr.Text,
                Count = tbCount.Text,
            });
            dgridBook.CancelEdit();
            dgridBook.Items.Refresh();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            dgridBook.Items.Add(new Book 
            {
                Autor = tbAutor.Text,
                Name = tbName.Text,
                Year = tbYear.Text,
                IZD = tbIZD.Text,
                Janr = tbJanr.Text,
                Count = tbCount.Text,
            });
            dgridBook.CancelEdit();
            dgridBook.Items.Refresh();
        }
    }
}
