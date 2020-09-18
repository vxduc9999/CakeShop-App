using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace MenuAnimation
{
    /// <summary>
    /// Interaction logic for CheckoutDetails.xaml
    /// </summary>
    public partial class CheckoutDetails : UserControl
    {
        public CheckoutDetails()
        {
            InitializeComponent();
        }
        ObservableCollection<Cakes> _data;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            long total = 0;
            var folder = AppDomain.CurrentDomain.BaseDirectory;
            var database = $"{folder}ShoppingCart.txt";
            var lines = File.ReadAllLines(database);
            int count = lines.Length / 6;
            _data = new ObservableCollection<Cakes>();
            for (int i = 0; i < count; i++)
            {
                var line1 = lines[i * 6];
                var line3 = lines[i * 6 + 2];
                var line4 = lines[i * 6 + 3];
                var line5 = lines[i * 6 + 4];
                var line6 = lines[i * 6 + 5];

                var p = new Cakes()
                {
                    Name = line1,
                    Price = int.Parse(line3),
                    Quantity = int.Parse(line4),
                    Total = long.Parse(line5),
                    ProductType = line6,
                };
                _data.Add(p);
            }
            dataListview.ItemsSource = _data;

            foreach (var t in _data)
            {
                total += t.Total;
            }

            double newValue = double.Parse(total.ToString());
            _total.Content = newValue.ToString("N0").Replace(",", ".") + " VNĐ";
        }

        private void _order_Click(object sender, MouseButtonEventArgs e)
        {
            _frame.Children.Clear();
            _frame.Children.Add(new UserControlOrder(_data));
        }

        private void _shoppingcart_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            _frame.Children.Clear();
            _frame.Children.Add(new UserControlShopping());
        }
    }
}
