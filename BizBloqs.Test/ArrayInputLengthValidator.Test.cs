using BizBloqs.Core.ExternalDependency;
using BizBloqs.Core.ExternalDependency.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace BizBloqs.Test
{
    public class ArrayInputLengthValidator
    {
        [Theory]
        [InlineData("BizBloqsIsHereWavingt")]
        [InlineData("BizBloqsIsH    ereWavingt")]
        public void InvalidLength(string value)
        {
            var result = Core._Validators.ArrayInputLengthValidator.IsValid(value);

            Assert.False(result);
        }

        [Theory]
        [InlineData("BizBloqs")]
        [InlineData("  BizBloqs  ")]
        public void IsValidLength(string value)
        {
            var result = Core._Validators.ArrayInputLengthValidator.IsValid(value);

            Assert.True(result);
        }
    }
}
