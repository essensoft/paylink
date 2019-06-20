using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankPaymentTradeNormalpayOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankPaymentTradeNormalpayOrderCreateModel : AlipayObject
    {
        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 渠道类型，表示请求的来源
        /// </summary>
        [JsonProperty("biz_channel")]
        public string BizChannel { get; set; }

        /// <summary>
        /// 外部平台的单据号，网商订单与外部平台订单一一对应
        /// </summary>
        [JsonProperty("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 用户的网商卡号
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonProperty("currency_value")]
        public string CurrencyValue { get; set; }

        /// <summary>
        /// 扩展参数，内容是JSON格式，并用urlconde编码，按场景约定具体字段  ETC场景：  etc_corp：高速公司名称
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 用户在网商的会员ID
        /// </summary>
        [JsonProperty("ipid")]
        public string Ipid { get; set; }

        /// <summary>
        /// 用户在网商的会员角色ID
        /// </summary>
        [JsonProperty("iproleid")]
        public string Iproleid { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [JsonProperty("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 请求流水号，表示外部一次请求，幂等字段
        /// </summary>
        [JsonProperty("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 请求时间，格式是yyyyMMddHHmmss
        /// </summary>
        [JsonProperty("request_time")]
        public string RequestTime { get; set; }
    }
}
