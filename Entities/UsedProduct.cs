using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.VisualBasic;

namespace exercFixacaoInheritance.Entities
{
    internal class UsedProduct : Product
    {
        public UsedProduct(string name, double price, DateTime manufactureDate  ) : base(name, price)
        {
            ManufactureDate= manufactureDate;
        }

        public DateTime ManufactureDate { get; set; }

        public override string PriceTag()
        {
            return Name
                + "( used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufature date: "
                + ManufactureDate.ToString("dd/MM/yyyy")
                + ")";
        }

    }
}
