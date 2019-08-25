using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossCsCssocialYqmessageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossCsCssocialYqmessageQueryModel : AlipayObject
    {
        /// <summary>
        /// 搜索条件字符串：搜索请求的JSON字符串，JSON字符串中:  posKeyword: 正向关键词  associationKeyword：搭配关键词  negKeyword：排除关键词（负向关键词）
        /// </summary>
        [JsonProperty("search_criteria")]
        public string SearchCriteria { get; set; }
    }
}
