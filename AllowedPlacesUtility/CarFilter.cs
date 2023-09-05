using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APU
{
    public class CarFilter
    {
        // properties
        public FileTypeSortMode SortMode { get; set; }
        public string NameFilter { get; set; }
        // maybe add places
        public SortOrder NameSortOrder { get; set; }

    }
}
