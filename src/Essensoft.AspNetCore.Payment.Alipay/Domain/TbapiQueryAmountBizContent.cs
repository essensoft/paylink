using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TbapiQueryAmountBizContent Data Structure.
    /// </summary>
    public class TbapiQueryAmountBizContent : AlipayObject
    {
        /// <summary>
        /// 查询指定额度产品组
        /// </summary>
        [JsonPropertyName("amt_group")]
        public string AmtGroup { get; set; }

        /// <summary>
        /// 查询指定额度产品码
        /// </summary>
        [JsonPropertyName("amt_prods")]
        public List<string> AmtProds { get; set; }

        /// <summary>
        /// 请求来源
        /// </summary>
        [JsonPropertyName("request_from")]
        public string RequestFrom { get; set; }

        /// <summary>
        /// 请求场景
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }
    }
}
