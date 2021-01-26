using System;
using System.Collections.Generic;
using System.Text;

namespace BizBloqs.Core._Validators
{
    public static class CheckIfHasValue
    {
        public static bool Validate(string value)
        {
            return String.IsNullOrWhiteSpace(value);
        }
    }
}
