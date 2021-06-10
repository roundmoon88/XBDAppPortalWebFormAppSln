using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XBDAppWebFormApp.DTO;

namespace XBDAppPortalWebFormApp.DAL
{
    public interface IAppEntityOperationBase
    { }
    public interface IAppEntityOperation<T> : IAppEntityOperationBase
    {
        T Resolve();
        
    }
    public interface IAppEntityOperationGetListByFilter<T> : IAppEntityOperationBase
    {//FilterDTO
        //T Resolve(IList<FilterEnum> fiters);
        T Resolve(IList<FilterDTO> fiters);
    }

}
