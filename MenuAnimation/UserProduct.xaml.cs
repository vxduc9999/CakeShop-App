using Aspose.Cells;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
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

namespace MenuAnimation
{
    /// <summary>
    /// Interaction logic for UserProduct.xaml
    /// </summary>
    /// public class trvTypeProduct
    public class trvTypeProduct
    {
        public trvTypeProduct()
        {
            this.Prod = new ObservableCollection<Proddd>();
        }

        public string Name { get; set; }

        public ObservableCollection<Proddd> Prod { get; set; }
    }

    public class Proddd
    {
        public string Name { get; set; }
    }
    public partial class UserProduct : UserControl
    {
        public UserProduct()
        {
            InitializeComponent();
        }
        ObservableCollection<Cakes> _data;
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var folder = AppDomain.CurrentDomain.BaseDirectory;
            var database = $"{folder}AllCakes.xlsx";
            var ad = database.Length;
            var workbook = new Workbook(database);
            var sheet = workbook.Worksheets[0];
            if (_nameComboBox.SelectedIndex == 0)
            {
                sheet = workbook.Worksheets[0];
            }
            if (_nameComboBox.SelectedIndex == 2)
            {
                sheet = workbook.Worksheets[1];
            }
            else if (_nameComboBox.SelectedIndex == 1)
            {
                sheet = workbook.Worksheets[2];
            }
            else if (_nameComboBox.SelectedIndex == 4)
            {
                sheet = workbook.Worksheets[6];
            }
            else if (_nameComboBox.SelectedIndex == 6)
            {
                sheet = workbook.Worksheets[3];
            }
            else if (_nameComboBox.SelectedIndex == 3)
            {
                sheet = workbook.Worksheets[4];
            }
            else if (_nameComboBox.SelectedIndex == 5)
            {
                sheet = workbook.Worksheets[5];
            }
            _data = new ObservableCollection<Cakes>();
            int index = 1;

            var cell = sheet.Cells[$"A{index}"];
            var count = sheet.Cells[$"K{index}"];
            for (int i = 1; i <= count.IntValue; i++)
            {
                var _Name = sheet.Cells[$"A{i}"].StringValue;
                var _Price = long.Parse(sheet.Cells[$"C{i}"].StringValue);
                var _Picture = sheet.Cells[$"F{i}"].StringValue;
                var Cak = new Cakes()
                {
                    ImagePath = _Picture,
                    Name = _Name,
                    Price = _Price
                };
                _data.Add(Cak);
            }
            this._pagination.Visibility = Visibility.Hidden;
            if (_data.Count > 12)
            {
                this._pagination.Visibility = Visibility.Visible;
            }

            info.CurrentPage = 1;
            info.RowsPerPage = 12;
            info.Count = _data.Count;
            info.TotalPages = (info.Count / info.RowsPerPage) +
                (info.Count % info.RowsPerPage == 0 ? 0 : 1);

            Thread thread = new Thread(delegate ()
            {
                // Cập nhật UI
                Dispatcher.Invoke(() =>
                {
                    dataListview.ItemsSource = _data.Take(info.RowsPerPage);
                });
            });

            thread.Start();
        }

        PagingInfo info = new PagingInfo();
        class PagingInfo : INotifyPropertyChanged
        {
            public int TotalPages { get; set; }

            private int _currentPage = 0;
            public int CurrentPage
            {
                get => _currentPage;
                set
                {
                    _currentPage = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CurrentPage"));
                }
            }
            private int _page1 = 1;
            public int Page1
            {
                get => _page1;
                set
                {
                    _page1 = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Page1"));
                }
            }
            private int _page2 = 2;
            public int Page2
            {
                get => _page2;
                set
                {
                    _page2 = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Page2"));
                }
            }
            private int _page3 = 3;
            public int Page3
            {
                get => _page3;
                set
                {
                    _page3 = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Page3"));
                }
            }

            public int Count { get; set; }
            public int RowsPerPage { get; set; }

            public event PropertyChangedEventHandler PropertyChanged;
        }

        private void Next_Click(object sender, MouseButtonEventArgs e)
        {
            if (info.CurrentPage < info.TotalPages)
            {
                info.CurrentPage++;
                dataListview.ItemsSource =
                _data
                    .Skip((info.CurrentPage - 1) * info.RowsPerPage)
                    .Take(info.RowsPerPage);
            }
        }

        private void Prev_Click(object sender, MouseButtonEventArgs e)
        {
            if (info.CurrentPage <= info.TotalPages)
            {
                info.CurrentPage--;
                dataListview.ItemsSource =
                _data
                    .Skip((info.CurrentPage - 1) * info.RowsPerPage)
                    .Take(info.RowsPerPage);
                if (info.CurrentPage <= 1)
                {
                    info.CurrentPage = 1;
                }
            }
        }

        private void dataListview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (sender as ListView).SelectedItem as Cakes;
            int index = dataListview.Items.IndexOf(item) + ((info.CurrentPage - 1) * info.RowsPerPage);
            if (item != null)
            {
                _frame.Children.Clear();
                _frame.Children.Add(new UserControlDetailCakes(item));
            }
        }

        public delegate void PositionNotifyDelegate(string n);
        public event PositionNotifyDelegate PositionChanged;
        int total = 0;
        private void orther_Click(object sender, RoutedEventArgs e)
        {
            var item = (sender as FrameworkElement).DataContext;
            int index = dataListview.Items.IndexOf(item) + ((info.CurrentPage - 1) * info.RowsPerPage);
            total++;
            PositionChanged?.Invoke(total.ToString());
            int temp = 0;
            int flag = 0;
            var folder = AppDomain.CurrentDomain.BaseDirectory;
            var database = $"{folder}ShoppingCart.txt";
            var lines = File.ReadAllLines(database);
            for (int i = 0; i < lines.Length; i += 6)
            {
                if (lines[i] == _data[index].Name)
                {
                    flag = 1;
                    temp = int.Parse(lines[i + 3]);
                    temp += 1;
                    lines[i + 3] = temp.ToString();
                    File.WriteAllLines(database, lines);
                    break;
                }
            }

            if (flag == 0)
            {
                using (StreamWriter sw = File.AppendText(database))
                {
                    sw.WriteLine(_data[index].Name);
                    sw.WriteLine(_data[index].ImagePath);
                    sw.WriteLine(_data[index].Price);
                    sw.WriteLine(_data[index].Quantity = 1);
                    sw.WriteLine(_data[index].Price * _data[index].Quantity);
                    sw.WriteLine(_data[index].ProductType);
                }
            }
            _frame.Children.Clear();
            _frame.Children.Add(new UserControlShopping());
        }


        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var folder = AppDomain.CurrentDomain.BaseDirectory;
            var database = $"{folder}AllCakes.xlsx";
            var ad = database.Length;
            var workbook = new Workbook(database);
            var sheet = workbook.Worksheets[0];
            if (_nameComboBox.SelectedIndex == 0)
            {
                sheet = workbook.Worksheets[0];
            }
            if (_nameComboBox.SelectedIndex == 2)
            {
                sheet = workbook.Worksheets[1];
            }
            else if (_nameComboBox.SelectedIndex == 1)
            {
                sheet = workbook.Worksheets[2];
            }
            else if (_nameComboBox.SelectedIndex == 4)
            {
                sheet = workbook.Worksheets[6];
            }
            else if (_nameComboBox.SelectedIndex == 6)
            {
                sheet = workbook.Worksheets[3];
            }
            else if (_nameComboBox.SelectedIndex == 3)
            {
                sheet = workbook.Worksheets[4];
            }
            else if (_nameComboBox.SelectedIndex == 5)
            {
                sheet = workbook.Worksheets[5];
            }
            _data = new ObservableCollection<Cakes>();
            int index = 1;

            var cell = sheet.Cells[$"A{index}"];
            var count = sheet.Cells[$"K{index}"];
            for (int i = 1; i <= count.IntValue; i++)
            {
                var _Name = sheet.Cells[$"A{i}"].StringValue;
                var _Price = long.Parse(sheet.Cells[$"C{i}"].StringValue);
                var _Picture = sheet.Cells[$"F{i}"].StringValue;
                var Cak = new Cakes()
                {
                    ImagePath = _Picture,
                    Name = _Name,
                    Price = _Price
                };
                _data.Add(Cak);
            }
            this._pagination.Visibility = Visibility.Hidden;
            if (_data.Count > 12)
            {
                this._pagination.Visibility = Visibility.Visible;
            }

            info.CurrentPage = 1;
            info.RowsPerPage = 12;
            info.Count = _data.Count;
            info.TotalPages = (info.Count / info.RowsPerPage) +
                (info.Count % info.RowsPerPage == 0 ? 0 : 1);

            Thread thread = new Thread(delegate ()
            {
                // Cập nhật UI
                Dispatcher.Invoke(() =>
                {
                    dataListview.ItemsSource = _data.Take(info.RowsPerPage);
                });
            });

            thread.Start();
        }
    }
}
