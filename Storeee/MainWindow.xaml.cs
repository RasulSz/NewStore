using Store.Model;
using Storeee;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Store
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
        public ObservableCollection<Product> Products { get; set; } = new()
        {
            new Product() {Id= 1, Name  = "Cola", Price = 1.2},
            new Product() {Id= 2, Name  = "Borjomi", Price = 1.55},
            new Product() {Id= 3, Name  = "7Up", Price = 1.99},
            new Product() {Id= 4, Name  = "Sirab", Price = 0.85},
            new Product() {Id= 5, Name  = "Vita1000", Price = 1.96},
            new Product() {Id= 6, Name  = "Laimon", Price = 1.1},
            new Product() {Id= 7, Name  = "Pepsi Twist", Price = 0.9},
            new Product() {Id= 8, Name  = "Mirinda", Price = 1.99},
            new Product() {Id= 9, Name  = "Lipton", Price = 1.2},
            new Product() {Id= 10, Name  = "Aquavita", Price = 0.65},
        };

        private void list_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Menu menu = new();
            menu.Product = (sender as ListBox)?.SelectedItem as Product;
            Hide();
            var dr = menu.ShowDialog();
            Show();
        }

        private void new_Click(object sender, RoutedEventArgs e)
        {
            Basket basket = new();
            Hide();
            var dr = basket.ShowDialog();
            Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Add add = new();
            Hide();
            var dr=add.ShowDialog();
            Show();
        }
    }
}
