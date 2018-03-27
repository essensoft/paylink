using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMobilePublicLabelQueryResponse.
    /// </summary>
    public class AlipayMobilePublicLabelQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [JsonProperty("code")]
        public new string Code { get; set; }

        /// <summary>
        /// 所有标签
        /// </summary>
        [JsonProperty("labels")]
        public List<string> Labels { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [JsonProperty("msg")]
        public new string Msg { get; set; }
    }
}
