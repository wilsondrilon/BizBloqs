using BizBloqs.Core;
using BizBloqs.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BizBloqs.Controllers
{
    [Route("api/v1")]
    [ApiController]
    public class WordController : ControllerBase
    {
        private readonly IStoreTextCore _storeTextCore;

        public WordController(IStoreTextCore storeTextCore)
        {
            _storeTextCore = storeTextCore;
        }

        [Route("word")]
        [HttpPost]
        public async Task<IActionResult> Insert(StoreTextCoreModel data)
        {
           var response = await _storeTextCore.Insert(data);
            return Ok(response);
        } 

        [Route("word/vowel")]
        [HttpGet]
        public async Task<IActionResult> GetVowels()
        {
            var response = await _storeTextCore.GetVowels();
            return Ok(response);
        }
    }
}
