using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject
{
    internal class Buy
    {
        double Piece = 0;

        public void bill(double pay, double money)
        {
            this.Piece = money - pay;
        }
        public double getbill()
        {
            return Piece;
        }
    }
}
