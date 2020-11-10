using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    class Kayak_INV
    {
        public int KayakInvID { get; set; }
        public int KayakID { get; set; }
        public string KayakColor { get; set; }
        public string KayakName { get; set; }
        public int KayakWieght { get; set; }
        public blob KayakPicture { get; set; }
        public int KayakCAP { get; set; }
        public int KayakLength { get; set; }
    }
}
