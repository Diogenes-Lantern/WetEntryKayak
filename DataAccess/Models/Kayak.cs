using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    internal class Kayak
    {
        public int KayakID { get; set; }
        public string KayakType { get; set; }
        public String KayakColor { get; set; }
        public string KayakName { get; set; }
        public int KayakWeight { get; set; }
        public blob KayakPicture { get; set; }
        public int KayakCap { get; set; }
        public int KayakLength { get; set; }
        public int KayakDiscr { get; set; }
    }
}
