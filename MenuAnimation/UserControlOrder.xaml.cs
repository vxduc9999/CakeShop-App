using Aspose.Cells;
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
using static System.Console;

namespace MenuAnimation
{
    /// <summary>
    /// Interaction logic for UserControlOrder.xaml
    /// </summary>
    public partial class UserControlOrder : UserControl
    {
        ObservableCollection<Cakes> _data = new ObservableCollection<Cakes>();
        public UserControlOrder(ObservableCollection<Cakes> _d)
        {
            InitializeComponent();
            _data = _d;
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            DateTime dt = DateTime.Now;
            var day = dt.ToString("dd");
            var month = dt.ToString("MM");
            var year = dt.ToString("yyyy");
            long total = 0;
            dataListview.ItemsSource = _data;

            foreach (var t in _data)
            {
                total += t.Total;
            }

            double newValue = double.Parse(total.ToString());
            _total.Content = newValue.ToString("N0").Replace(",", ".") + " VNĐ";

            _orderNumber.Text += "0xFFFFF";
            _orderDate.Text += day + " Tháng " + month + ", " + year;
            _orderTotal.Text += newValue.ToString("N0").Replace(",", ".") + " VNĐ";
            _orderPayment.Text += "Trả tiền mặt khi nhận hàng.";
        }

        private void okButton_Click(object sender, MouseButtonEventArgs e)
        {
            var folder = AppDomain.CurrentDomain.BaseDirectory;
            var database = $"{folder}ShoppingCart.txt";
            var db = $"{folder}AllCakes.xlsx";
            File.Delete(database);
            File.Create(database);

            // Xu li luu vao file excel
            Workbook wb = new Workbook(db);
            Worksheet sheet = wb.Worksheets[7];

            char column = 'A';
            int row = 2;
            Cell cell = sheet.Cells[$"{column}{row}"];
            DateTime dt = DateTime.Now;
            int m = dt.Month;

            for (int i = 0; i < _data.Count; i++)
            {
                while (cell.Value != null)
                {
                    if (cell.StringValue == _data[i].ProductType)
                    {
                        char c = (char)(m + 65);
                        cell = sheet.Cells[$"{c}{row}"];
                        cell.Value = Int64.Parse(cell.StringValue) + (_data[i].Quantity * _data[i].Price);
                        WriteLine(cell.Value);
                        row = 2;
                        cell = sheet.Cells[$"{column}{row}"];
                        break;
                    }
                    else
                    {
                        row++;
                        cell = sheet.Cells[$"{column}{row}"];
                    }

                }
            }
            wb.Save(db, SaveFormat.Xlsx);
            //
            _frame.Children.Clear();
            _frame.Children.Add(new USHome());
        }
    }
}
