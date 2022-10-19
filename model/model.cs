using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFAppNote.model
{
    //[MenuTitle], [NoteTitle], [NoteText],[NoteCreateDateTime] ,[NoteEditDateTime], [ColorText]
    public class Item
    {
        public int Id { get; set; }
        public string MenuTitle { get; set; }
        public string NoteTitle { get; set; }
        public string NoteText { get; set; }
        public DateTime NoteCreateDateTime { get; set; }
        public DateTime NoteEditDateTime { get; set; }
        public string ColorText { get; set; }

    }
   

   
}
