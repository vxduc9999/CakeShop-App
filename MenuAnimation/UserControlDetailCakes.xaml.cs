using System;
using Aspose.Cells;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Collections.ObjectModel;
using System.IO;

namespace MenuAnimation
{
    /// <summary>
    /// Interaction logic for UserControlDetailCakes.xaml
    /// </summary>
    public partial class UserControlDetailCakes : UserControl
    {
        public Cakes _data;

        Cakes prod;
        ObservableCollection<Cakes> _list;
        string nameProduct;
        public UserControlDetailCakes(Cakes t)
        {
            InitializeComponent();
            _data = t;
            nameProduct = _data.Name;
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = _data;
            _list = new ObservableCollection<Cakes>();
            var folder = AppDomain.CurrentDomain.BaseDirectory;
            var database = $"{folder}AllCakes.xlsx";
            var workbook = new Workbook(database);
            var sheet = workbook.Worksheets[0];
            var row = 1;
            var cell = sheet.Cells[$"A{row}"];
            while (cell.Value != null)
            {
                if (_data.Name == cell.StringValue)
                {
                    _data.Description= sheet.Cells[$"B{row}"].StringValue;
                    _data.Price= long.Parse(sheet.Cells[$"C{row}"].StringValue);
                    _data.ProductType= sheet.Cells[$"D{row}"].StringValue;
                    break;
                }
                else
                {
                    row++;
                    cell = sheet.Cells[$"A{row}"];
                }
            }
            prod = new Cakes()
            {
                Name = _data.Name,
                Description = _data.Description,
                Price = _data.Price,
                ImagePath = _data.ImagePath,
                ProductType=_data.ProductType,
                listImages = new BindingList<string>()
            };

            var count = sheet.Cells[$"E{row}"].IntValue;
            var col = 'F';
            for (int i = 0; i < count; i++)
            {
                var value = $"{folder}ListCakes\\{nameProduct}\\" + sheet.Cells[$"{char.ConvertFromUtf32(col + i)}{row}"].StringValue;
                prod.listImages.Add(value);
            };
            _list.Add(prod);
            PreviewPhoto.ItemsSource = _list;
        }
        int count = 1;
        private void Minus_MouseUp(object sender, MouseButtonEventArgs e)
        {
            count = int.Parse(_number.Text.ToString());
            count--;
            if (count < 1) count = 1;
            _number.Text = count.ToString();
        }

        private void Plus_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var count = int.Parse(_number.Text.ToString());
            count++;
            _number.Text = count.ToString();
        }

        private void _editProduct_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            _frame.Children.Clear();
            _frame.Children.Add(new UserControlUpdate(prod));
        }

        private void orderProduct(object sender, MouseButtonEventArgs e)
        {
            int temp = 0;
            int flag = 0;
            var folder = AppDomain.CurrentDomain.BaseDirectory;
            var database = $"{folder}ShoppingCart.txt";
            var lines = File.ReadAllLines(database);
            for (int i = 0; i < lines.Length; i += 6)
            {
                if (lines[i] == prod.Name)
                {
                    flag = 1;
                    temp = int.Parse(lines[i + 3]);
                    temp += int.Parse(_number.Text);
                    lines[i + 3] = temp.ToString();
                    File.WriteAllLines(database, lines);
                    break;
                }
            }

            if (flag == 0)
            {
                using (StreamWriter sw = File.AppendText(database))
                {
                    sw.WriteLine(prod.Name);
                    sw.WriteLine(prod.ImagePath);
                    sw.WriteLine(prod.Price);
                    sw.WriteLine(prod.Quantity = int.Parse(_number.Text));
                    sw.WriteLine(prod.Price * prod.Quantity);
                    sw.WriteLine(prod.ProductType);
                }
            }
            _frame.Children.Clear();
            _frame.Children.Add(new UserControlShopping());
        }
    }
}
