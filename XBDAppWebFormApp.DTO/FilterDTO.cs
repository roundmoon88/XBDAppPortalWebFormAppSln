using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XBDAppWebFormApp.DTO
{
    public class FilterDTO
    {
        public int ItemId { get; set; }
        public string Item { get; set; }
        public bool Selected { get; set; }
        public FilterEnum FilterName { get; set; }
    }

    public enum FilterEnum
    {
        App = 1,
        AppType = 2
    }
}
