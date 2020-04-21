using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AddTagRequest Data Structure.
    /// </summary>
    public class AddTagRequest : AlipayObject
    {
        /// <summary>
        /// biz_id，唯一，业务id，用于业务请求的幂等标志
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 饿了么schainId
        /// </summary>
        [JsonPropertyName("schain_id")]
        public string SchainId { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
