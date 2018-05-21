using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell_Phone_Inventory
{
    class CellPhone
    {

            private string brand;
            private string model;
            private decimal price;

            public CellPhone()
            {
                brand = "";
                model = "";
                price = 0m;
            }

            public string Brand
            {
                get { return brand; }
                set { brand = value; }
            }

            public string Model
            {
                get { return model; }
                set { model = value; }

            }

            public decimal Price
            {
                get { return price; }
                set { price = value; }
            }

        
    }
}
