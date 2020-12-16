using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditmerchantProductorderTransferModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditmerchantProductorderTransferModel : AlipayObject
    {
        /// <summary>
        /// 生效时间
        /// </summary>
        [JsonPropertyName("active_datetime")]
        public string ActiveDatetime { get; set; }

        /// <summary>
        /// 补充字段
        /// </summary>
        [JsonPropertyName("extending_info")]
        public string ExtendingInfo { get; set; }

        /// <summary>
        /// 应用来源
        /// </summary>
        [JsonPropertyName("from_app")]
        public string FromApp { get; set; }

        /// <summary>
        /// 失效时间
        /// </summary>
        [JsonPropertyName("inactive_datetime")]
        public string InactiveDatetime { get; set; }

        /// <summary>
        /// 退订接受时间
        /// </summary>
        [JsonPropertyName("inactiving_datetime")]
        public string InactivingDatetime { get; set; }

        /// <summary>
        /// 订购原来
        /// </summary>
        [JsonPropertyName("ordered_channel")]
        public string OrderedChannel { get; set; }

        /// <summary>
        /// 订购系统码
        /// </summary>
        [JsonPropertyName("ordered_system_code")]
        public string OrderedSystemCode { get; set; }

        /// <summary>
        /// 接受订购时间
        /// </summary>
        [JsonPropertyName("ordering_datetime")]
        public string OrderingDatetime { get; set; }

        /// <summary>
        /// 外部商户ID
        /// </summary>
        [JsonPropertyName("out_merchant_id")]
        public string OutMerchantId { get; set; }

        /// <summary>
        /// 商户支付宝ID
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 销售产品码
        /// </summary>
        [JsonPropertyName("ps_code")]
        public string PsCode { get; set; }

        /// <summary>
        /// 续订标志
        /// </summary>
        [JsonPropertyName("renew")]
        public string Renew { get; set; }

        /// <summary>
        /// 原淘宝服务市场订购单号
        /// </summary>
        [JsonPropertyName("taobao_order_id")]
        public string TaobaoOrderId { get; set; }
    }
}
