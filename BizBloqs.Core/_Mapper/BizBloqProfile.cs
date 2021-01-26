using BizBloqs.Core.Models;
using BizBloqs.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BizBloqs.Core._Mapper
{
    public class BizBloqProfile: AutoMapper.Profile
    {
        public BizBloqProfile()
        {
            CreateMap<StoreTextCoreModel, StoredText>();
            CreateMap<StoredText, StoreTextCoreModel>();
        }        
    }
}
