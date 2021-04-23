using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MybankPaymentTradeNormalpayOrderCreateModel Data Structure.
    /// </summary>
    public class MybankPaymentTradeNormalpayOrderCreateModel : AlipayObject
    {
        /// <summary>
        /// 订单金额，单位:分
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 渠道类型，表示请求的来源 ANT_OPEN=蚂蚁开放平台
        /// </summary>
        [JsonPropertyName("biz_channel")]
        public string BizChannel { get; set; }

        /// <summary>
        /// 外部平台的单据号，建议和request_no保持一致
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 买家信息，user_info_type表示账户类型，ALIPAY_UID=支付宝UID，BANK_UID=网商会员角色ID，MYBANK_CARD_NO=网商卡号，样例内容是{"user_info_type":"ALIPAY_UID","user_info_id":"2088102146225135"}，在进行urlencode
        /// </summary>
        [JsonPropertyName("buyer_info")]
        public string BuyerInfo { get; set; }

        /// <summary>
        /// 网商卡号，具体是买方还是卖方，按接入场景而定，详情咨询开发小二
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 关单时间，格式是数字+单位，m=分钟，h=小时，d=天
        /// </summary>
        [JsonPropertyName("close_time")]
        public string CloseTime { get; set; }

        /// <summary>
        /// 币种，156=人民币
        /// </summary>
        [JsonPropertyName("currency_value")]
        public string CurrencyValue { get; set; }

        /// <summary>
        /// 扩展参数，内容是JSON格式，并用urlconde编码
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 网商会员ID，具体是买方还是卖方，按接入场景而定，详情咨询开发小二
        /// </summary>
        [JsonPropertyName("ipid")]
        public string Ipid { get; set; }

        /// <summary>
        /// 网商会员角色ID，具体是买方还是卖方，按接入场景而定，详情咨询开发小二
        /// </summary>
        [JsonPropertyName("iproleid")]
        public string Iproleid { get; set; }

        /// <summary>
        /// 订单类型， NORMAL_PAY=通用支付
        /// </summary>
        [JsonPropertyName("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 收方资产信息，内容是JSON格式，并用urlencode编码，样例内容是[{"accountName":"张三", "accountNo":"620227193903043336","accountType":"EXTEND_BANK_CARD"}]
        /// </summary>
        [JsonPropertyName("payee_fund_detail")]
        public string PayeeFundDetail { get; set; }

        /// <summary>
        /// 付方资产信息，内容是JSON格式，并用urlencode编码，样例内容是[{"accountName":"张三", "accountNo":"620227193903043336","accountType":"EXTEND_BANK_CARD"}]
        /// </summary>
        [JsonPropertyName("payer_fund_detail")]
        public string PayerFundDetail { get; set; }

        /// <summary>
        /// 网商对账单的备注信息
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 请求流水号，表示外部一次请求，控重字段
        /// </summary>
        [JsonPropertyName("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 请求时间，格式是yyyyMMddHHmmss
        /// </summary>
        [JsonPropertyName("request_time")]
        public string RequestTime { get; set; }

        /// <summary>
        /// 卖家信息，user_info_type表示账户类型，ALIPAY_UID=支付宝UID，BANK_UID=网商会员角色ID，MYBANK_CARD_NO=网商卡号，样例内容是{"user_info_type":"ALIPAY_UID","user_info_id":"2088102146225135"}，再进行urlencode
        /// </summary>
        [JsonPropertyName("seller_info")]
        public string SellerInfo { get; set; }
    }
}
