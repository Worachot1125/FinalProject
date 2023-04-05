using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finalproject
{
    public partial class Pay : Form
    {
        public Pay()
        {
            InitializeComponent();
        }
        Buy payMange = new Buy();

        private void button1_Click(object sender, EventArgs e)
        {
            string Cost_room = this.tbCostRoom.Text;
            string pay = this.tbPaymoney.Text;


            double iCost_room = Convert.ToDouble(Cost_room);
            double ipay = Convert.ToDouble(pay);

            payMange.bill(iCost_room, ipay);
            double ichange = payMange.getbill();

            if (iCost_room > ipay)
            {
                MessageBox.Show("จำนวนเงินไม่พอ");
            }
            if (iCost_room <= ipay)
            {
                MessageBox.Show("ขอบคุณที่ชำระเงิน");
                tbChange.Text = ichange.ToString();
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public string price;
        private void Pay_Load(object sender, EventArgs e)
        {
            tbCostRoom.Text = price;
        }
    }
}
