using Finalproject.AllRoom;
using FinalProject;
using System.Numerics;


namespace Finalproject
{
    public partial class Form1 : Form
    {
        List<Member> listMember = new List<Member>();
        List<Room> room;
        Member selectedMember;
        Room selectedRoom;

        int index;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = listMember;

            room = new List<Room>();
            room.Add(new roomA());
            room.Add(new roomB());
            room.Add(new roomC());
            room.Add(new roomD());
            room.Add(new roomE());
        }

        private void inputMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputMember inputmember = new inputMember();
            inputmember.ShowDialog();

            if (inputmember.DialogResult == DialogResult.OK)
            {
                Member newMember = inputmember.getMember();
                this.listMember.Add(newMember);

                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = listMember;

                inputmember.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pay pay = new Pay();
            pay.price = tbPrice.Text;
            pay.ShowDialog();

        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "TEXT|*.txt|CSV|*.csv";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    foreach (Member item in listMember)
                    {
                        writer.WriteLine(String.Format("{0},{1},{2},{3},{4},{5}",
                            item.ชื่อ,
                            item.เลขบัตรประชาชน,
                            item.เบอร์โทรศัพท์,
                            item.อีเมล,
                            item.วันที่จอง,
                            item.ห้องที่จอง));

                    }
            }
        }
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "TEXT|*.txt|CSV|*.csv";
            openFileDialog.ShowDialog();
            string filename = openFileDialog.FileName;
            string readfile = File.ReadAllText(filename);
            tbOpen.Text = readfile;
        }

        private void btA_Click(object sender, EventArgs e)
        {
            selectedRoom = room[0];
            this.tbPrice.Text = selectedRoom.getPrice().ToString();
        }

        private void btB_Click(object sender, EventArgs e)
        {
            selectedRoom = room[1];
            this.tbPrice.Text = selectedRoom.getPrice().ToString();
        }

        private void btC_Click(object sender, EventArgs e)
        {
            selectedRoom = room[2];
            this.tbPrice.Text = selectedRoom.getPrice().ToString();
        }

        private void btD_Click(object sender, EventArgs e)
        {
            selectedRoom = room[3];
            this.tbPrice.Text = selectedRoom.getPrice().ToString();
        }

        private void btE_Click(object sender, EventArgs e)
        {
            selectedRoom = room[4];
            this.tbPrice.Text = selectedRoom.getPrice().ToString();
        }
    }
}
