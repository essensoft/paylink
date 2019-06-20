using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountFinriskInstriskmonitorKeywordsBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayAccountFinriskInstriskmonitorKeywordsBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 查询机构关键词
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }
    }
}
