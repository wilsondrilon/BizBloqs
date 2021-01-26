using BizBloqs.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BizBloqs.Data
{
    public class StoreTextData : IStoreTextData
    {
        private readonly IBizBloqsContext _context;

        public StoreTextData(IBizBloqsContext context)
        {
            _context = context;
        }
        public async Task<bool> Insert(StoredText store)
        {
            _context.StoredTexts.Add(store);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<StoredText>> GetEverySecondRow()
        {
            var result = await _context.StoredTexts.FromSqlRaw($"GetEverySecondRowOnStoredText").ToListAsync();
            return result;
        }
    }
}
