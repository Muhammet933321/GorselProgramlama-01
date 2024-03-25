using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace GorselProgramlama_01
{
    public class BookCLass
    {
        public BookCLass(int id, string name, int numberOfPages, string writerName, int state) 
        { 
            this.id = id; 
            this.name = name;
            this.numberOfPages = numberOfPages;
            this.writerName = writerName;
            this.state = state;

        
        }
        public int id;
        public string name;
        public int numberOfPages;
        public string writerName;
        public int state;

    }
}
