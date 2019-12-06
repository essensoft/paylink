using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsTradeInfo Data Structure.
    /// </summary>
    public class InsTradeInfo : AlipayObject
    {
        /// <summary>
        /// 产品编码  交强险-01010000002000000251,   商业险-01010000002000000250
        /// </summary>
        [JsonPropertyName("product_no")]
        public string ProductNo { get; set; }

        /// <summary>
        /// 车险内部订单号
        /// </summary>
        [JsonPropertyName("trade_biz_id")]
        public string TradeBizId { get; set; }
    }
}
