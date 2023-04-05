using Finalproject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class inputMember : Form
    {
        private Member _newMember;
        public inputMember()
        {
            InitializeComponent();
        }

        private void btComfirm_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string ID = tbID.Text;
            string phone = tbPhone.Text;
            string email = tbEmail.Text;
            string room = cbbRoom.Text;
            string dateTime = dateTimePicker1.Text;

            _newMember = new Member(name, ID, phone, email, dateTime, room);
            this.DialogResult = DialogResult.OK;



        }
        public Member getMember() { return _newMember; }

        private void btClear_Click(object sender, EventArgs e)
        {
            this.tbName.Text = "";
            this.tbID.Text = "";
            this.tbEmail.Text = "";
            this.cbbRoom.Text = "";
        }
    }
}
