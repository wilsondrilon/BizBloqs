using BizBloqs.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BizBloqs.Data
{
    public class BizBloqsContext: DbContext
    {
        public BizBloqsContext(DbContextOptions options) 
            : base(options) { }

        public DbSet<StoredText> StoredTexts { get; set; }
    }
}
