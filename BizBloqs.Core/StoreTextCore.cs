using AutoMapper;
using BizBloqs.Core._Helper;
using BizBloqs.Core.Models;
using BizBloqs.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using BizBloqs.Core.ExternalDependency;
using BizBloqs.Core.ExternalDependency.Models;
using BizBloqs.Core._Validators;

namespace BizBloqs.Core
{
    public class StoreTextCore : IStoreTextCore
    {
        private readonly IStoreTextData _data;
        private readonly IMapper _mapper;
        private readonly IGeneralResponse _generalResponse;
        private readonly IBizBloqsManager _bizBloqsManager;

        public StoreTextCore(IStoreTextData data, IMapper mapper, IGeneralResponse generalResponse, IBizBloqsManager bizBloqsManager)
        {
            _data = data;
            _mapper = mapper;
            _generalResponse = generalResponse;
            _bizBloqsManager = bizBloqsManager;
        }

        public async Task<dynamic> Insert(StoreTextCoreModel data)
        {


            if (CheckIfHasValue.Validate(data.data))
            {
                return _generalResponse.Response(null, Convert.ToInt32(HttpStatusCode.BadRequest), "Provided data is invalid, Value must not be null, empty or whitespace", true);
            }

            if (!InputLengthValidator.IsValid(data.data))
            {
                return _generalResponse.Response(null, Convert.ToInt32(HttpStatusCode.BadRequest), "String length is invalid!", true);
            }


            await _data.Insert(_mapper.Map<Data.Entity.StoredText>(data));
            return _generalResponse.Response(null, Convert.ToInt32(HttpStatusCode.OK), "Data Inserted!", true);
        }

        public async Task<dynamic> GetVowels()
        {
            var dataList = await _data.GetEverySecondRow();
            var listDataModel = new List<DataModel>();
            foreach(var data in dataList)
            {
                listDataModel.Add(new DataModel { Text = data.Data });
            };
            var vowelsCount = _bizBloqsManager.ProcessData(listDataModel);

            var dataConstruct = new
            {
                TextList = dataList,
                TotalVowels = vowelsCount.VowelCount
            };

            return _generalResponse.Response(dataConstruct, Convert.ToInt32(HttpStatusCode.OK), "Data has been generated!", true);
        }
    }
}
