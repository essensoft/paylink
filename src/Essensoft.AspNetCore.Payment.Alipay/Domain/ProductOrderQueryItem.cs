using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ProductOrderQueryItem Data Structure.
    /// </summary>
    public class ProductOrderQueryItem : AlipayObject
    {
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
