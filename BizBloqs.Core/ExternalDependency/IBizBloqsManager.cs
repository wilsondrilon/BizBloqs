using BizBloqs.Core.ExternalDependency.Models;
using System.Collections.Generic;

namespace BizBloqs.Core.ExternalDependency
{
    public interface IBizBloqsManager
    {
        ResultModel ProcessData(IEnumerable<DataModel> dataList);
    }
}