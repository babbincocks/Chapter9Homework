using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell_Phone_Inventory
{
    class CellPhone
    {
            //Backing variabls to hold the different aspects of a cell phone.
            private string brand;
            private string model;
            private decimal price;

            //Constructor to set the default values.
            public CellPhone()
            {
                brand = "";
                model = "";
                price = 0m;
            }

            //Method to return the phone brand.
            public string Brand
            {
                get { return brand; }
                set { brand = value; }
            }

            //Method to return the phone model.
            public string Model
            {
                get { return model; }
                set { model = value; }

            }

            //Method to return the phone price.
            public decimal Price
            {
                get { return price; }
                set { price = value; }
            }

        
    }
}
