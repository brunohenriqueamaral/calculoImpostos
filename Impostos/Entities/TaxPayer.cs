using System;
using System.Collections.Generic;
using System.Text;

namespace Impostos.Entities
{
     abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }
        
       

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
            
        }

        public TaxPayer()
        {
        }

        public abstract double Tax();
    }
}
