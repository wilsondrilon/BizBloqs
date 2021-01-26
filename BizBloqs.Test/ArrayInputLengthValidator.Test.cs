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
        [InlineData("bolters                                                           ")]
        public void InvalidLength(string value)
        {
            var result = Core._Validators.InputLengthValidator.IsValid(value);

            Assert.False(result);
        }

        [Theory]
        [InlineData("BizBloqs")]
        [InlineData("  BizBloqs  ")]
        public void IsValidLength(string value)
        {
            var result = Core._Validators.InputLengthValidator.IsValid(value);

            Assert.True(result);
        }
    }
}
