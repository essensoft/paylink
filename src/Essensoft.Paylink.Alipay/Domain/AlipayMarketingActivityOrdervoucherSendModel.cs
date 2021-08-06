using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherSendModel Data Structure.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherSendModel : AlipayObject
    {
        /// <summary>
        /// 优惠券活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 服务商发放商家券的时间。  格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("biz_dt")]
        public string BizDt { get; set; }

        /// <summary>
        /// 推广渠道信息。 由支付宝公私域跳转到服务商小程序时带入。例如 aalipays://platformapi/startapp?appId=2021002147682XXX&page=pages/main/mian&query=chInfo%3DchInfo_promotion  其中chInfo为支付宝带入投放渠道信息，需要在调用发券接口时传入
        /// </summary>
        [JsonPropertyName("ch_info")]
        public string ChInfo { get; set; }

        /// <summary>
        /// 用户领券之后在服务商(商户)侧提供的券详情展示页面。在支付宝卡包中展示链接，用户点击可以跳转到服务商券详情页。  限制: 该字段在兑换券场景下必传。 链接必须是alipays开头的小程序链接，详见《小程序scheme链接介绍》https://opendocs.alipay.com/support/01rb18
        /// </summary>
        [JsonPropertyName("merchant_order_url")]
        public string MerchantOrderUrl { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。  幂等作用： 参数不变的情况下，再次请求返回与上一次相同的结果。  外部接入方需保证业务单号唯一
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商家券售卖交易渠道，用于安全审核。  枚举值：  ZHIFUBAO_TRADE_CHANNEL： 支付宝交易渠道 限制: 商家券售卖场景必传。
        /// </summary>
        [JsonPropertyName("trade_channel")]
        public string TradeChannel { get; set; }

        /// <summary>
        /// 该交易在支付宝系统中的交易流水号。
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
