using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMycarTradeOrderQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoMycarTradeOrderQueryModel : AlipayObject
    {
        /// <summary>
        /// 车主平台交易号，与车主业务平台订单号相同。和trade_no，out_biz_trade_no不能同时为空。
        /// </summary>
        [JsonPropertyName("biz_trade_no")]
        public string BizTradeNo { get; set; }

        /// <summary>
        /// 外部订单号，和biz_trade_no，trade_no不能同时为空
        /// </summary>
        [JsonPropertyName("out_biz_trade_no")]
        public string OutBizTradeNo { get; set; }

        /// <summary>
        /// 支付宝交易号。该笔车主平台对应的支付宝交易编号，使用该交易号也可以直接调用支付宝开放平台的交易查询接口查询交易信息。 和biz_trade_no，out_biz_trade_no不能同时为空。
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
