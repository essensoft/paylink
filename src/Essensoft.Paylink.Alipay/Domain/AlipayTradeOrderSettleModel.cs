using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayTradeOrderSettleModel Data Structure.
    /// </summary>
    public class AlipayTradeOrderSettleModel : AlipayObject
    {
        /// <summary>
        /// 操作员 ID，商家自定义操作员编号。
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 结算请求流水号，由商家自定义。32个字符以内，仅可包含字母、数字、下划线。需保证在商户端不重复。
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 分账明细信息。 注意：商家分账场景下分账收入方 trans_in 只支持支付宝账户，不支持使用 cardAliasNo 卡编号。
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
