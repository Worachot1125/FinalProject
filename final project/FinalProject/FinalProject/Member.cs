using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject
{
    public class Member
    {
        private string Name, MemberID, Phone, Email, DateTime, Room;

        public Member(string Name, string MemberID, string Phone, string Email, string DateTime, string Room)
        {
            this.Name = Name;
            this.MemberID = MemberID;
            this.Phone = Phone;
            this.Email = Email;
            this.DateTime = DateTime;
            this.Room = Room;
        }

        public string ชื่อ { get => Name; }
        public string เลขบัตรประชาชน { get => MemberID; }
        public string เบอร์โทรศัพท์ { get => Phone; }
        public string อีเมล { get => Email; }
        public string วันที่จอง { get => DateTime; }
        public string ห้องที่จอง { get => Room; }
    }
}
