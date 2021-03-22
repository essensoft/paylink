using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ProductOrderQueryItem Data Structure.
    /// </summary>
    public class ProductOrderQueryItem : AlipayObject
    {
        /// <summary>
        /// 是否需要查活动信息
        /// </summary>
        [JsonPropertyName("need_activity")]
        public bool NeedActivity { get; set; }

        /// <summary>
        /// 订购渠道
        /// </summary>
        [JsonPropertyName("ordered_channel")]
        public string OrderedChannel { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonPropertyName("ps_code")]
        public string PsCode { get; set; }
    }
}
