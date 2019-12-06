using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeOrderSettleModel Data Structure.
    /// </summary>
    public class AlipayTradeOrderSettleModel : AlipayObject
    {
        /// <summary>
        /// 操作员id
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 结算请求流水号 开发者自行生成并保证唯一性
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 分账明细信息
        /// </summary>
        [JsonPropertyName("royalty_parameters")]
        public List<OpenApiRoyaltyDetailInfoPojo> RoyaltyParameters { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
