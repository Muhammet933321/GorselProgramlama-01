using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama_01.MemberFolder
{
    public class MemberClass
    {
        public MemberClass(int ID, string Name, string Mail)
        {
            this.ID = ID;
            this.Name = Name;
            this.Mail = Mail;
        }
        public MemberClass() { }
        public int ID;
        public string Name;
        public string Mail;
    }
}
