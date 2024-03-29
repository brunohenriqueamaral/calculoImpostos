﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Impostos.Entities
{
    class Individual : TaxPayer
    {

        public double HelthExpenditures { get; set; }
        public Individual()
        {

        }

     

        public Individual(string name, double anualIncome, double helthExpenditures )
            :base (name, anualIncome)
        {
            HelthExpenditures = helthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.0)
            {
                return AnualIncome * 0.15 - HelthExpenditures * 0.5;
            }
            else
            {
                return AnualIncome * 0.25 - HelthExpenditures * 0.5;
            }    
        }

    }
}
