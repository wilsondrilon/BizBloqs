﻿using BizBloqs.Core.Models;

namespace BizBloqs.Core._Validators
{
    public static class ArrayInputLengthValidator
    {
        public static bool IsValid(string data)
        {
            return data.Length <= 20 ? true : false;   
        }
    }
}
