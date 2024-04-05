using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama_01.HireFolder
{
    public class HiresClass
    {
        public int UserId;
        public int BookId;
        public DateTime HireTime;
        public DateTime ReturnTime;
        private readonly TimeSpan MaxHireTime = new TimeSpan(14, 0, 0, 0);
        public HiresClass()
        {
            HireTime = DateTime.Now;
            ReturnTime = HireTime + MaxHireTime;
        }
        public HiresClass(int UserId, int BookId)
        {
            this.UserId = UserId;
            this.BookId = BookId;
            HireTime = DateTime.Now;
            ReturnTime = HireTime + MaxHireTime;
        }
        
    }
}
