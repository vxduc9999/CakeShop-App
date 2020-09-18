using LiveCharts;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MenuAnimation
{
    public class Cakes 
    {
        // Properties
        public SeriesCollection Data { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public long Price { get; set; }
        public System.DateTime Date { get; set; }
        public int InitialAmount { get; set; }
        public int CurrentAmount { get; set; }
        public string Description { get; set; }
        public string ProductType { get; set; }
        public string ImagePath { get; set; }
        public int Quantity { get; set; }
        public long Total { get; set; }
        public BindingList<string> listImages { get; set; }
    }
}
