using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuAnimation
{
    class ProductType
    {
        public ProductType()
        {
            this.Products = new ObservableCollection<Cakes>();
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int NumOfProduct { get; set; }
        public System.DateTime Date { get; set; }
        public string Description { get; set; }
        public virtual ObservableCollection<Cakes> Products { get; set; }
    }
}
