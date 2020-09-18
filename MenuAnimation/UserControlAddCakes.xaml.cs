using Aspose.Cells;
using MenuAnimado1;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for UserControlAddCakes.xaml
    /// </summary>
    public partial class UserControlAddCakes : UserControl
    {
        public UserControlAddCakes()
        {
            InitializeComponent();
        }
        private void imgSave_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (textBoxName.Text.Trim() != "" && Img.ItemsSource != null && textBoxDescription.Text.Trim() != "" && textBoxPrice.Text.Trim() != "" && comboBoxitemType.Text.Trim() != "")
            {
                MessageBoxResult result = MessageBox.Show("Bạn có muốn lưu?", "", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    var folder = AppDomain.CurrentDomain.BaseDirectory;
                    var database = $"{folder}AllCakes.xlsx";
                    var workbook = new Workbook(database);
                    var sheet = workbook.Worksheets[0];

                    var row = 1;
                    var cell = sheet.Cells[$"A{row}"];

                    while (cell.Value != null)
                    {
                        row++;
                        cell = sheet.Cells[$"A{row}"];
                    }

                    sheet.Cells[$"A{row}"].PutValue(textBoxName.Text);
                    sheet.Cells[$"B{row}"].PutValue(textBoxDescription.Text);
                    sheet.Cells[$"C{row}"].PutValue(textBoxPrice.Text.ToString().Replace(",", ""));
                    sheet.Cells[$"D{row}"].PutValue(comboBoxitemType.Text.ToString());
                    sheet.Cells[$"E{row}"].PutValue(_listImages.Count());
                    sheet.Cells[$"F{row}"].PutValue(System.IO.Path.GetFileName(_listImages[0]));
                    sheet.Cells[$"K{1}"].PutValue(row);

                    var sheet1 = workbook.Worksheets[0];
                    if(comboBoxitemType.Text=="Bánh Kem")
                    {
                        sheet1 = workbook.Worksheets[6];
                    }else if (comboBoxitemType.Text == "Bánh Ngọt")
                    {
                        sheet1 = workbook.Worksheets[2];
                    }
                    if (comboBoxitemType.Text == "Bánh Mì")
                    {
                        sheet1 = workbook.Worksheets[1];
                    }
                    if (comboBoxitemType.Text == "Bánh Đóng Gói")
                    {
                        sheet1 = workbook.Worksheets[5];
                    }
                    if (comboBoxitemType.Text == "Bánh Kem Nhỏ")
                    {
                        sheet1 = workbook.Worksheets[6];
                    }
                    if (comboBoxitemType.Text == "Bánh Theo Mùa")
                    {
                        sheet1 = workbook.Worksheets[4];
                    }
                    var row1 = 1;
                    var cell1 = sheet.Cells[$"A{row1}"];

                    while (cell1.Value != null)
                    {
                        row1++;
                        cell1 = sheet1.Cells[$"A{row1}"];
                    }

                    sheet1.Cells[$"A{row1}"].PutValue(textBoxName.Text);
                    sheet1.Cells[$"B{row1}"].PutValue(textBoxDescription.Text);
                    sheet1.Cells[$"C{row1}"].PutValue(textBoxPrice.Text.ToString().Replace(",", ""));
                    sheet1.Cells[$"D{row1}"].PutValue(comboBoxitemType.Text.ToString());
                    sheet1.Cells[$"E{row1}"].PutValue(_listImages.Count());
                    sheet1.Cells[$"F{row1}"].PutValue(System.IO.Path.GetFileName(_listImages[0]));
                    sheet1.Cells[$"K{1}"].PutValue(row1);

                    var imgFolder = $"{folder}Images";
                    string imgProd = System.IO.Path.GetFileName(_listImages[0]);
                    var appStartPathImgProd = String.Format(imgFolder + "\\" + imgProd);
                    if (!File.Exists(imgFolder + "\\" + imgProd))
                    {
                        File.Copy(_listImages[0], appStartPathImgProd, true);
                    }

                    var listImgFolder = $"{folder}\\ListCakes\\{textBoxName.Text}";
                    if (!Directory.Exists(listImgFolder))
                    {
                        Directory.CreateDirectory(listImgFolder);
                        foreach (string nameImg in _listImages)
                        {
                            string name = System.IO.Path.GetFileName(nameImg);
                            if (File.Exists(listImgFolder + "\\" + name))
                            {
                                //
                            }
                            else
                            {
                                appStartPathImgProd = String.Format(listImgFolder + "\\" + name);
                                File.Copy(nameImg, appStartPathImgProd, true);
                            }
                        }
                    }

                    var col = 'F';
                    for (int i = 1; i < _listImages.Count(); i++)
                    {
                        sheet.Cells[$"{char.ConvertFromUtf32(col + i)}{row}"].PutValue(System.IO.Path.GetFileName(_listImages[i]));
                        sheet1.Cells[$"{char.ConvertFromUtf32(col + i)}{row1}"].PutValue(System.IO.Path.GetFileName(_listImages[i]));
                    };

                    sheet.AutoFitColumns();
                    sheet.AutoFitRows();
                    sheet1.AutoFitColumns();
                    sheet1.AutoFitRows();
                    workbook.Save(database);

                    _addCakes.Children.Clear();
                    _addCakes.Children.Add(new UserProduct());
                }
            }
            else
                MessageBox.Show("Không được để trống tên, loại, giá, mô tả và hình ảnh của sản phẩm!!!");
        }

        private void imgCancel_MouseUp(object sender, MouseButtonEventArgs e)
        {
            _addCakes.Children.Clear();
            _addCakes.Children.Add(new UserProduct());
        }

        ObservableCollection<string> _listImages = new ObservableCollection<string>();
        private void ChooseImg_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "Image Files(*.jpg; *.png; *.jpeg; *.gif; *.bmp)|*.jpg; *.png; *.jpeg; *.gif; *.bmp";
            bool? result = open.ShowDialog();
            if (result == true)
            {
                foreach (string item in open.FileNames)
                {
                    _listImages.Add(item);
                }
                Img.ItemsSource = _listImages;
            }
        }

        private void Price_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Length > 0)
            {
                double value = 0;
                double.TryParse(textBox.Text, out value);
                textBox.Text = value.ToString("N0");
                textBox.CaretIndex = textBox.Text.Length;
            }
        }
    }
}
