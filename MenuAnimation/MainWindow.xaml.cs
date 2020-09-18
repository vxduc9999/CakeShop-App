using MaterialDesignThemes.Wpf;
using MenuAnimation;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace MenuAnimado1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _frame.Children.Clear();
            _frame.Children.Add(new USHome());
        }
        UserProduct _product = new UserProduct();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _product.PositionChanged += Orther_PositionChanged;
            _frame.Children.Clear();
            _frame.Children.Add(new USHome());
        }

        private void Orther_PositionChanged(string n)
        {
            Thread thread = new Thread(delegate ()
            {
                // Cập nhật UI
                Dispatcher.Invoke(() =>
                {
                    Total.Content = n;
                });
            });

            thread.Start();
        }

        private void labelHome_MouseUp(object sender, MouseButtonEventArgs e)
        {
            _frame.Children.Clear();
            _frame.Children.Add(new USHome());
        }

        private void labelAbout_MouseUp(object sender, MouseButtonEventArgs e)
        {
            _frame.Children.Clear();
            _frame.Children.Add(new UserControlIntroduce());
        }

        private void labelProduct_MouseUp(object sender, MouseButtonEventArgs e)
        {
            _frame.Children.Clear();
            _frame.Children.Add(new UserProduct());
        }

        private void labelContact_MouseUp(object sender, MouseButtonEventArgs e)
        {

            _frame.Children.Clear();
            _frame.Children.Add(new UserControlAddCakes());
        }

        private void newProduct_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            //NewProduct p = new NewProduct();
            //p.Show();
            //this.Close();
        }

        private void labelChart_MouseUp(object sender, MouseButtonEventArgs e)
        {
            _frame.Children.Clear();
            _frame.Children.Add(new UserControlChars());
        }

        private void _cart(object sender, MouseButtonEventArgs e)
        {
            _frame.Children.Clear();
            _frame.Children.Add(new UserControlShopping());
        }
    }
}
