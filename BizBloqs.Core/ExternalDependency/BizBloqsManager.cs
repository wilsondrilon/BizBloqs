using BizBloqs.Core.ExternalDependency.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BizBloqs.Core.ExternalDependency
{

    public class BizBloqsManager : IBizBloqsManager
    {
        /// <summary>
        /// Process data will loop through the data and count all the vowels (a,e,i,o,u) in the text.  
        /// </summary>
        /// <param name="dataList"></param>
        /// <returns>Count of all the vowels</returns>
        public ResultModel ProcessData(IEnumerable<DataModel> dataList)
        {
            #region Requirements

            /*
             Loop through the data list supplied.
             Loop through each of the characters in the text property
             Check each character and count the number of vowels (a,e,i,o,u) 
             Return the total number of vowels found in the data list
             */

            #endregion

            // Count of all the vowels
            var count = 0;

            foreach (var data in dataList)
            {
                data.Text = data.Text.ToLower();
                char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

                // Loop through all the text supplied and count the number of vowels (a,e,i,o,u)
                for (var i = 1; i < data.Text.Length; i++)
                {
                    //check if character exists as vowel
                    if (vowels.Any(data.Text[i].ToString().Contains))
                    {
                        count++;
                    }
                }
            }

            // Return the count of all the vowels
            return new ResultModel { VowelCount = count };
        }
    }
}
