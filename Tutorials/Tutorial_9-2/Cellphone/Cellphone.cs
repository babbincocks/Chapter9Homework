using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellphone
{
    class Cellphone
    {
        private string brand;
        private string model;
        private decimal price;

        public Cellphone()
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
