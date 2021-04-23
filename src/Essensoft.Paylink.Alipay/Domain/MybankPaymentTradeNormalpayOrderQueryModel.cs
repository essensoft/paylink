using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MybankPaymentTradeNormalpayOrderQueryModel Data Structure.
    /// </summary>
    public class MybankPaymentTradeNormalpayOrderQueryModel : AlipayObject
    {
        /// <summary>
        /// 渠道类型，表示请求的来源，ANT_OPEN=蚂蚁开放平台，使用request_no查询时，该字段必传
        /// </summary>
        [JsonPropertyName("biz_channel")]
        public string BizChannel { get; set; }

        /// <summary>
        /// 买家信息，user_info_type表示账户类型，ALIPAY_UID=支付宝UID，BANK_UID=网商会员角色ID，MYBANK_CARD_NO=网商卡号，样例内容是{"user_info_type":"ALIPAY_UID","user_info_id":"2088102146225135"}，在进行urlencode，使用request_no查询时，该字段必传
        /// </summary>
        [JsonPropertyName("buyer_info")]
        public string BuyerInfo { get; set; }

        /// <summary>
        /// 网商订单号，order_no和request_no传一个即可，优先取order_no
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 创单时的请求流水号，order_no和request_no传一个即可，优先取order_no
        /// </summary>
        [JsonPropertyName("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 卖家信息，user_info_type表示账户类型，ALIPAY_UID=支付宝UID，BANK_UID=网商会员角色ID，MYBANK_CARD_NO=网商卡号，样例内容是{"user_info_type":"ALIPAY_UID","user_info_id":"2088102146225135"}，再进行urlencode，使用request_no查询时，该字段必传
        /// </summary>
        [JsonPropertyName("seller_info")]
        public string SellerInfo { get; set; }
    }
}
