using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankPaymentTradeNormalpayOrderCreateModel Data Structure.
    /// </summary>
    public class MybankPaymentTradeNormalpayOrderCreateModel : AlipayObject
    {
        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 渠道类型，表示请求的来源
        /// </summary>
        [JsonPropertyName("biz_channel")]
        public string BizChannel { get; set; }

        /// <summary>
        /// 外部平台的单据号，网商订单与外部平台订单一一对应
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 用户的网商卡号
        /// </summary>
        [JsonPropertyName("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonPropertyName("currency_value")]
        public string CurrencyValue { get; set; }

        /// <summary>
        /// 扩展参数，内容是JSON格式，并用urlconde编码，按场景约定具体字段  ETC场景：  etc_corp：高速公司名称
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 用户在网商的会员ID
        /// </summary>
        [JsonPropertyName("ipid")]
        public string Ipid { get; set; }

        /// <summary>
        /// 用户在网商的会员角色ID
        /// </summary>
        [JsonPropertyName("iproleid")]
        public string Iproleid { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [JsonPropertyName("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 收方资产信息，内容是JSON格式，并用urlencode编码，按场景约定具体字段
        /// </summary>
        [JsonPropertyName("payee_fund_detail")]
        public string PayeeFundDetail { get; set; }

        /// <summary>
        /// 付方资产信息，内容是JSON格式，并用urlencode编码，按场景约定具体字段
        /// </summary>
        [JsonPropertyName("payer_fund_detail")]
        public string PayerFundDetail { get; set; }

        /// <summary>
        /// 请求流水号，表示外部一次请求，幂等字段
        /// </summary>
        [JsonPropertyName("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 请求时间，格式是yyyyMMddHHmmss
        /// </summary>
        [JsonPropertyName("request_time")]
        public string RequestTime { get; set; }
    }
}
