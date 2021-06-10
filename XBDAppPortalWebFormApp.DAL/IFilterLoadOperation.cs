using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XBDAppWebFormApp.DTO;

namespace XBDAppPortalWebFormApp.DAL
{
    interface IFilterLoadOperation
    {
        //IList<FilterEnum> filters used to list what kinds of filters to request
        //IList<FilterDTO> Resolve(IList<FilterEnum> filters);
        IList<FilterDTO> Resolve(FilterEnum filter);
    }
}
