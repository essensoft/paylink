using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicMatchuserLabelDeleteResponse.
    /// </summary>
    public class AlipayOpenPublicMatchuserLabelDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 用户打标失败数量
        /// </summary>
        [JsonProperty("error_count")]
        public long ErrorCount { get; set; }

        /// <summary>
        /// 出错的匹配器列表
        /// </summary>
        [JsonProperty("error_matchers")]
        public List<ErrorMatcher> ErrorMatchers { get; set; }
    }
}
