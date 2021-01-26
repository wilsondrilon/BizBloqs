using BizBloqs.Core.Models;
using System.Threading.Tasks;

namespace BizBloqs.Core
{
    public interface IStoreTextCore
    {
        Task<dynamic> Insert(StoreTextCoreModel data);
        Task<dynamic> GetVowels();
    }
}