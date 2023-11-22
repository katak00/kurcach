using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurcach
{
    public class OrderDetail
    {
        public int id { get; set; }
        public DateTime Data { get; set; }
        public string stoim { get; set; }
        public string vid_zatrat { get; set; }
        public string Gorod { get; set; }
        public string Total
        {
            get
            {
                return stoim;
            }
        }
    }
}
