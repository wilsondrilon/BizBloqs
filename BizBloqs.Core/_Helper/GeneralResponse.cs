﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BizBloqs.Core._Helper
{
    public class GeneralResponse : IGeneralResponse
    {
        public GeneralModel Response(dynamic data, int statusCode, string message, bool isSuccessful)
        {
            var dataResponse = new GeneralModel()
            {
                isSuccessful = isSuccessful,
                statusCode = statusCode,
                message = message,
                data = data
            };
            return dataResponse;
        }
    }
}
