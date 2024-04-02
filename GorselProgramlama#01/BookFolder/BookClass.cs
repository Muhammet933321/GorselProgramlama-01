using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorselProgramlama_01.BookFolder
{
    public class BookClass
    {
        public BookClass(int Id, string name, int NumberOfPages, string WriterName)
        {
            ID = Id;
            BookName = name;
            this.NumberOfPages = NumberOfPages;
            this.WriterName = WriterName;
            State = 0;
        }
        public BookClass() { }
        public int ID;
        public string BookName;
        public int NumberOfPages;
        public string WriterName;
        public int State;


    }
}
