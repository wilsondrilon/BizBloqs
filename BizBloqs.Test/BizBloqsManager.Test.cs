using BizBloqs.Core.ExternalDependency;
using BizBloqs.Core.ExternalDependency.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace BizBloqs.Test
{
    public class BizBloqManager
    {
        private readonly Core.ExternalDependency.BizBloqsManager _bizBloqsManager;

        public BizBloqManager()
        {
            _bizBloqsManager = new BizBloqsManager();
        }

        [Fact]
        public void CanCountVowels()
        {
            var value = new List<DataModel>()
            {
                new DataModel { Text = "BizBloqs"},
                new DataModel { Text = "GetAllVowels" }
            };

            var result = _bizBloqsManager.ProcessData(value);

            Assert.Equal(6, result.VowelCount);
        }
    }
}
