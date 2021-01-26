using BizBloqs.Core._Helper;
using BizBloqs.Core.Models;
using System.Threading.Tasks;

namespace BizBloqs.Core
{
    public interface IStoreTextCore
    {
        Task<GeneralModel> Insert(StoreTextCoreModel data);
        Task<GeneralModel> GetVowels();
    }
}