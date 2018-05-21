using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellphone
{
    class Cellphone
    {   //Very simple Cellphone class.

        //Three backing fields are created for the different aspects of the cell phone object.
        private string brand;
        private string model;
        private decimal price;

        //Constructor to contain the default values for the backing fields.
        public Cellphone()
        {
            brand = "";
            model = "";
            price = 0m;
        }

        //Accessor for the phone brand.
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        //Accessor for the phone model.
        public string Model
        {
            get { return model; }
            set { model = value; }

        }

        //Accessor for the price model.
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

    }
}
