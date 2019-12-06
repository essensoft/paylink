using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankPaymentTradeFinancingOrderCloseModel Data Structure.
    /// </summary>
    public class MybankPaymentTradeFinancingOrderCloseModel : AlipayObject
    {
        /// <summary>
        /// 扩展字段，JSON格式 URLEncoder.encode(String,"UTF-8")
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 合作机构编码，阿里云填aliyun
        /// </summary>
        [JsonPropertyName("ext_partner")]
        public string ExtPartner { get; set; }

        /// <summary>
        /// order_no
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单类型，FINANCING_PAY-预付融资
        /// </summary>
        [JsonPropertyName("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        [JsonPropertyName("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 请求时间，格式yyyyMMddHHmmss
        /// </summary>
        [JsonPropertyName("request_time")]
        public string RequestTime { get; set; }

        /// <summary>
        /// 填MYBKC1CN，表示网商
        /// </summary>
        [JsonPropertyName("tnt_inst_id")]
        public string TntInstId { get; set; }
    }
}
