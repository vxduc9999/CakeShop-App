using Aspose.Cells;
using System;
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
using LiveCharts;
using LiveCharts.Wpf;

namespace MenuAnimation
{
    /// <summary>
    /// Interaction logic for UserControlChars.xaml
    /// </summary>
    public partial class UserControlChars : UserControl
    {
        public UserControlChars()
        {
            InitializeComponent();
        }
        BindingList<Cakes> _list;
        BindingList<ViewModel> _listSale;

        private void UserControl_Initialized(object sender, EventArgs e)
        {
            _listSale = new BindingList<ViewModel>();
            ItemSFChart.ItemsSource = _listSale;

            _list = new BindingList<Cakes>();
            ItemPieChart.ItemsSource = _list;
            this.DataContext = this;

            var g = new Cakes()
            {
                Data = new SeriesCollection(),
            };

            var folder = AppDomain.CurrentDomain.BaseDirectory;
            var database = $"{folder}ListCakes\\DB_DA3.xlsx";
            var ad = database.Length;
            var workbook = new Workbook(database);
            var sheet = workbook.Worksheets[1];


            var row = 2;


            ViewModel SF = new ViewModel()
            {
                Datas = new List<Sale>(),
            };





            var cell = sheet.Cells[$"A{row}"];
            int i = 12;

            int j = 1;

            var ColumSF = 'B';
            while (cell.Value != null)
            {

                PieSeries Pie = new PieSeries()
                {
                    Values = new ChartValues<float> { float.Parse(sheet.Cells[$"C{row}"].StringValue) },
                    Title = $"{cell.StringValue}"
                };
                g.Data.Add(Pie);

                row++;
                cell = sheet.Cells[$"A{row}"];
            }
            while (j <= 12)
            {
                Sale sf = new Sale()
                {
                    Price = float.Parse(sheet.Cells[$"{char.ConvertFromUtf32(ColumSF + j - 1)}8"].StringValue),
                    Month = $"{j}"
                };

                SF.Datas.Add(sf);

                j++;
            }
            _listSale.Add(SF);
            _list.Add(g);
        }

    }
}
