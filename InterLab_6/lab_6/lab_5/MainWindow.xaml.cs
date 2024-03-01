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
using Application = System.Windows.Application;

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

            List<string> styles = new List<string> { "dark", "light" };
            styleBox.SelectionChanged += ThemeChange;
            styleBox.ItemsSource = styles;
            styleBox.SelectedItem = "light";

            dgridBook.ItemsSource = bookList.Items;
            dgridBook.Items.Refresh();
        }

        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string style = styleBox.SelectedItem as string;
            var uri = new Uri(style + ".xaml", UriKind.Relative);
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private void LoadFromXML(object sender, RoutedEventArgs e)
        {
            var formatter = new XmlSerializer(typeof(BookList));
            var fs = new FileStream("Resources\\data.xml", FileMode.OpenOrCreate);
            bookList = (BookList)formatter.Deserialize(fs);
            dgridBook.ItemsSource = bookList.Items;
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
            bookList.Items.Clear();
            dgridBook.Items.Refresh();
            //dgridBook.ItemsSource = null;
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            bookList.Items.RemoveAt(dgridBook.SelectedIndex);
            dgridBook.Items.Refresh();
            clearAllTextBox();
        }

        private void clearAllTextBox()
        {
            tbAutor.Text = "";
            tbName.Text = "";
            tbYear.Text = "";
            tbIZD.Text = "";
            tbJanr.Text = "";
            tbCount.Text = "";
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
            dgridBook.Items.Refresh();
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            bookList.Items.Add(new Book
            {
                Autor = tbAutor.Text,
                Name = tbName.Text,
                Year = tbYear.Text,
                IZD = tbIZD.Text,
                Janr = tbJanr.Text,
                Count = tbCount.Text,
            });
            dgridBook.Items.Refresh();
        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            Book book = dgridBook.SelectedItem as Book;
            if (book != null)
            {
                tbAutor.Text = book.Autor;
                tbName.Text = book.Name;
                tbYear.Text = book.Year;
                tbIZD.Text = book.IZD;
                tbJanr.Text = book.Janr;
                tbCount.Text = book.Count;
            }

        }
    }
}

