using BizBloqs.Data.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BizBloqs.Data
{
    public interface IStoreTextData
    {
        Task<bool> Insert(StoredText store);

        Task<IEnumerable<StoredText>> GetEverySecondRow();
    }
}