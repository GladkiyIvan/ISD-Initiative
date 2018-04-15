using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6
{
    class Converter
    {
        public double USD;
        public double EUR;
        public double RUB;
        public Converter(double usd, double eur, double rub)
        {
            USD = usd;
            EUR = eur;
            RUB = rub;
        }

        public double ConvertToUSD(double UAH)
        {
            return UAH / USD;
        }

        public double ConvertToEUR(double UAH)
        {
            return UAH / EUR;
        }

        public double ConvertToRUB(double UAH)
        {
            return UAH / RUB;
        }

        public double ConvertFromUSD(double USD)
        {
            return USD * this.USD;
        }

        public double ConvertFromEUR(double EUR)
        {
            return EUR * this.EUR;
        }

        public double ConvertFromRUB(double RUB)
        {
            return RUB * this.RUB;
        }
    }
}
