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

namespace BooksStoreGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BooksStoreBL.BookStoreBL booksStoreBL; 
        public MainWindow()
        {
            booksStoreBL = new BooksStoreBL.BookStoreBL();
            
            InitializeComponent();
            var res = booksStoreBL.GetAllBooks();
            BooksDataGrid.ItemsSource = res;
            var res2 = booksStoreBL.a();
            BooksDataGrid.ItemsSource = res2;
            var res3 = booksStoreBL.b();
            BooksDataGrid.ItemsSource = res3;
            var res4 = booksStoreBL.c();
            BooksDataGrid.ItemsSource = res4;
            var res5 = booksStoreBL.d();
            BooksDataGrid.ItemsSource = res5;

        }
    }
}
